using System.Collections.Concurrent;
using PCRClient;
using PCRClient.Models;

namespace PCRFarm;

public class Farm
{
    private readonly Config _config;
    private readonly PcrClient[] _masters;
    private readonly BlockingCollection<PcrClient> _workers = new();
    private readonly List<PcrClient> _usedWorkers = new();
    private readonly List<PcrClient> _allWorkers = new();

    private static async Task<CaptchaResult> Validator(CaptchaRequest captcha)
    {
        await Task.Yield();
        Console.WriteLine($"https://help.tencentbot.top/geetest/?captcha_type=1&challenge={captcha.challenge}&gt={captcha.gt}&userid={captcha.gt_user_id}&gs=1");
        return captcha.CreateResult(Console.ReadLine() ?? string.Empty);
    }

    private static PcrClient CreateClient(AccountInfo info)
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
    }

    private async Task<PcrClient> GetWorker()
    {
        for (;;)
        {
            if (_workers.TryTake(out var val)) return val;
            await Task.Delay(_config.requestDelay);
        }
    }

    private static readonly List<List<long>> _pendingInvites = new ();

    private async Task MasterListener(PcrClient master)
    {
        var invites = new List<long>();
        var copy = new List<long>();

        lock (_pendingInvites)
            _pendingInvites.Add(invites);
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
                    await master.InviteToClan(worker);

                    try
                    {
                        var questId = 0;
                        while (worker.Inventory.Get(new InventoryType { id = request.equip_id, type = eInventoryType.Equip }) <= 2)
                        {
                            if (questId == 0)
                            {
                                questId = (int)PcrClientSessionBase.Database!.QuestData.First(q =>
                                    q.RewardImage1 == request.equip_id || q.RewardImage2 == request.equip_id).QuestId;
                            }

                            if (worker.Stamina < 30) await worker.RecoverStamina(); // TODO: deal with the situation that jewel is not enough
                            await worker.QuestSkip(questId, 3);
                        }
                        await worker.DonateEquip(request, 2);
                        i += 2;
                    }
                    catch (ApiException)
                    {
                        //捐过了，没开图，没钻石，直接bypass
                    }

                    await master.RemoveMember(worker.ViewerId);

                    if (worker.DonationNum < 10) _workers.Add(worker);
                    else lock (_usedWorkers) _usedWorkers.Add(worker);
                }

                donated.Add(request.message_id);
            }

            lock (invites)
            {
                copy.AddRange(invites);
                invites.Clear();
            }

            foreach (var id in copy) await master.InviteToClan(id);
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

    public void Invite(long user)
    {
        Console.WriteLine($"inviting {user}");
        var rnd = new Random();
        lock (_pendingInvites)
        {
            var invites = _pendingInvites[rnd.Next(0, _pendingInvites.Count)];
            lock (invites)
            {
                invites.Add(user);
            }
        }
    }
}