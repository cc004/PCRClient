using System.Collections.Concurrent;
using BandoriBot;
using PCRClient;
using PCRClient.Models;
using PCRFarm.Apis.Controllers;
using ApiException = PCRClient.ApiException;
using Utils = PCRClient.Utils;

namespace PCRFarm;

public class Farm
{
    private readonly Config _config;
    private readonly PcrClient[] _masters;
    private readonly BlockingCollection<PcrClient> _workers = new();
    private readonly List<PcrClient> _usedWorkers = new();
    private readonly List<PcrClient> _allWorkers = new();

    private async Task<CaptchaResult> Validator(CaptchaRequest captcha)
    {
        await Task.Yield();
        var sema = new Semaphore(0, 1);
        string validate = null!;
        ApiController.RegisterCallback(captcha.challenge!, v =>
        {
            validate = v;
            sema.Release();
        });
        await MessageHandler.session.SendGroupMessage(1,
            $"http://{_config.host}/geetest?captcha_type=1&challenge={captcha.challenge}&gt={captcha.gt}&userid={captcha.gt_user_id}&gs=1");
        sema.WaitOne();
        return captcha.CreateResult(validate);
    }
    
    private PcrClient CreateClient(AccountInfo info)
    {
        return new PcrClient(EnvironmentInfo.Default)
        {
            Account = info,
            Validator = Validator
        };
    }

    public Farm(Config config)
    {
        _config = config;
        _masters = config.masters.Select(CreateClient).ToArray();
        foreach (var worker in config.workers.Select(CreateClient))
        {
            _workers.Add(worker);
            _allWorkers.Add(worker);
        }
        new Thread(() =>
        {
            Apis.Program.Main2(ushort.Parse(config.host.Split(':')[1]));
        }).Start();
    }

    private async Task<PcrClient> GetWorker()
    {
        for (;;)
        {
            if (_workers.TryTake(out var val)) return val;
            await Task.Delay(_config.requestDelay);
        }
    }

    private static readonly List<List<Func<PcrClient, Task>>> _invokeList = new ();

    private async Task MasterListener(PcrClient master)
    {
        var invokes = new List<Func<PcrClient, Task>>();
        var copy = new List<Func<PcrClient, Task>>();

        lock (_invokeList)
            _invokeList.Add(invokes);
        var donated = new HashSet<int>();
        for (;;)
        {
            var requests = await master.GetEquipmentRequests() ?? Array.Empty<EquipRequests>();
            donated.IntersectWith(requests.Select(r => r.message_id));
            foreach (var request in requests.Where(r => !donated.Contains(r.message_id)))
            {
                for (var i = request.donation_num; i < request.request_num;)
                {
                    var worker = await GetWorker();

                    try
                    {
                        var questId = 0;
                        while (worker.Inventory.Get(new InventoryType { id = request.equip_id, type = eInventoryType.Equip }) <= 2)
                        {
                            if (questId == 0)
                            {
                                questId = (int) (PcrClientSessionBase.Database!.QuestData.Where(q =>
                                                         q.RewardImage1 == request.equip_id ||
                                                         q.RewardImage2 == request.equip_id)
                                                     .AsEnumerable()
                                                     .FirstOrDefault(
                                                         q => worker.FinishedQuest.Contains((int) q.QuestId)) ??
                                                 throw new ApiException<QuestSkipResponse>()).QuestId;
                            }

                            if (worker.Stamina < 30) await worker.RecoverStamina(); // TODO: deal with the situation that jewel is not enough
                            await worker.QuestSkip(questId, 3);
                        }
                        await master.InviteToClan(worker);
                        try
                        {
                            await worker.DonateEquip(request, 2);
                            i += 2;
                        }
                        catch (ApiException)
                        {

                        }
                        await master.RemoveMember(worker.ViewerId);
                    }
                    catch (ApiException)
                    {
                        //捐过了，没开图，没钻石，直接bypass
                    }


                    if (worker.DonationNum < 10) _workers.Add(worker);
                    else lock (_usedWorkers) _usedWorkers.Add(worker);
                }

                donated.Add(request.message_id);
            }

            copy.Clear();
            lock (invokes)
            {
                copy.AddRange(invokes);
                invokes.Clear();
            }

            foreach (var act in copy) await act(master);
            await Task.Delay(_config.requestDelay);
        }
    }

    private static readonly TimeSpan offset = TimeSpan.FromHours(6);

    private async Task DailyReLoginScheduler()
    {
        var last = DateTime.Now - offset;
        for (;;)
        {
            var now = DateTime.Now - offset;
            if (now.DayOfYear == last.DayOfYear) continue;

            // clear used worker status
            last = now;
            foreach (var worker in _allWorkers)
                worker.ReLogin();
            lock (_usedWorkers)
            {
                foreach (var worker in _usedWorkers)
                    _workers.Add(worker);
                _usedWorkers.Clear();
            }
            await Task.Delay(_config.requestDelay);
        }
    }

    public async Task Start()
    {
        foreach (var master in _masters)
        {
            await master.ForceLogin();
            // ensure each master is an owner of clan
            if (master.ClanId == 0)
                await master.CreateClan();
            else if ((await master.GetCurrentClanInfo())!.members.First(m => m.viewer_id == master.ViewerId).role !=
                     eClanRole.LEADER)
            {
                Console.WriteLine($"fatal: master account {master.Account?.username} is in an non-leader clan");
                return;
            }
        }
        foreach (var worker in _allWorkers)
        {
            // ensure any worker is not in an clan
            await worker.ForceLogin();
            if (worker.ClanId == 0) continue;
            var master = _masters.FirstOrDefault(m => m.ClanId == worker.ClanId);
            if (master != null)
                await master.RemoveMember(worker.ViewerId);
            else
                throw new Exception($"worker {worker.Account?.username} in an non-controllable clan");
        }
        foreach (var master in _masters)
            _ = Task.Run(() => MasterListener(master));
        _ = Task.Run(DailyReLoginScheduler);
    }

    private void InvokeEach(Func<PcrClient, Task> act)
    {
        lock (_invokeList)
        {
            foreach (var lst in _invokeList)
            {
                lock (lst) lst.Add(act);
            }
        }
    }

    public void Invite(long user)
    {
        Console.WriteLine($"inviting {user}");
        InvokeEach(async client =>
        {
            await client.InviteToClan(user);
        });
    }
    public void Kick(long user)
    {
        Console.WriteLine($"inviting {user}");
        InvokeEach(async client =>
        {
            try
            {
                await client.RemoveMember(user);
            }
            catch (ApiException)
            {

            }
        });
    }

    public string GetStatus()
    {
        return $"农场状态:\n{string.Join("\n", _allWorkers.Select(c => $"{c.Name}: {c.DonationNum}/10"))}";
    }
}