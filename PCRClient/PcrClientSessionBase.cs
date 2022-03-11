using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCRClient.Models;
using PCRClient.Models.Db;

namespace PCRClient;

// maintenance session, ensure every request is run in a valid session
// also maintenance asset manager and db context

public class PcrClientSessionBase : PcrClientApiBase
{
    public AssetManager? AssetManager { get; private set; }
    public MasterContext? Database { get; private set; }
    public AccountInfo? Account { get; set; }
    public Func<CaptchaRequest, Task<CaptchaResult>>? Validator { get; set; }
    
    public string DatabaseCacheDir { get; set; } = Path.Combine(Environment.CurrentDirectory, "temp");

    private BsGameSdk.BSdkLoginResult? _sdkAccount;
    private bool _logged, _logging;
    private string TokenPath => Path.Combine(DatabaseCacheDir,
        $"{Account?.username}.json");

    private async Task BiliLogin()
    {
        if (_sdkAccount == null)
        {
            Log(LogLevel.Info, "bsdk login");
            _sdkAccount = await BsGameSdk.Login(Account ?? throw new InvalidOperationException(), Validator);
            await File.WriteAllTextAsync(TokenPath, JsonConvert.SerializeObject(_sdkAccount));
        }
    }

    private static readonly int[] tutorialSteps =
    {
        1, 2, 3, 4, 5, 6, 7, 20, 30, 40, 50, 60, 100
    };

    protected async Task SkipTutorial(string name = "\u4f51\u6811")
    {
        foreach (var step in tutorialSteps)
            await Request(new TutorialUpdateRequest
            {
                step = step,
                skip = 0,
                user_name = name
            });
    }

    private static readonly Regex dateTime = new(@"\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}", RegexOptions.Compiled);
    private async Task Login()
    {
        _logging = true;

        if (File.Exists(TokenPath))
            _sdkAccount =
                JsonConvert.DeserializeObject<BsGameSdk.BSdkLoginResult>(await File.ReadAllTextAsync(TokenPath));

        for (;;)
        {
            try
            {
                for (;;)
                {
                    var manifest = await Prepare(Account ?? throw new InvalidOperationException());
                    if (string.IsNullOrEmpty(manifest.maintenance_message)) break;
                    var match = dateTime.Match(manifest.maintenance_message);
                    if (match.Success)
                    {
                        var now = DateTime.Parse(match.Value);
                        while (DateTime.Now < now) await Task.Delay(60000);
                    }
                    else await Task.Delay(60000);
                }

                for (;;)
                {
                    await BiliLogin();
                    if (string.IsNullOrEmpty(_sdkAccount?.access_key))
                    {
                        Log(LogLevel.Error, "bsdk login");
                        continue;
                    }
                    if (!(await Request(new ToolSdkLoginRequest
                        {
                            uid = _sdkAccount.uid,
                            access_key = _sdkAccount.access_key,
                            platform = Account.platform.ToString(),
                            channel_id = Account.channel.ToString()
                        })).is_risk) break;
                    _sdkAccount = null;
                }

                if (!(await Request(new CheckGameStartRequest
                    {
                        apptype = 0,
                        campaign_data = string.Empty,
                        campaign_user = new Random().Next(100000) & ~1
                    })).now_tutorial)
                {
                    await SkipTutorial();
                }

                await Request(new CheckAgreementRequest());
                await Request(new LoadIndexRequest
                {
                    carrier = "OPPO"
                });

                Directory.CreateDirectory(DatabaseCacheDir);
                AssetManager = await CreateAssetManager(DatabaseCacheDir);
                Log(LogLevel.Info, "asset manager");
                Database = await AssetManager.CreateMasterContext();
                Log(LogLevel.Info, "database");

                await Request(new HomeIndexRequest
                {
                    message_id = 1,
                    gold_history = 0,
                    is_first = 1,
                    tips_id_list = Array.Empty<int>()
                });
                _logged = true;
                _logging = false;
                Log(LogLevel.Info, "logged in");
                break;
            }
            catch (ApiException e)
            {
                Log(LogLevel.Error, e.Message);
            }
        }
    }

    protected PcrClientSessionBase(EnvironmentInfo? info = null) : base(info)
    {
    }

    protected override async Task<T> Request<T>(Request<T> request)
    {
        await ForceLogin();
        return await base.Request(request);
    }
    private async Task<AssetManager> CreateAssetManager(string cacheDir)
    {
        var manifest = await Request(new SourceIniGetMaintenanceStatusRequest());
        return await AssetManager.Create(manifest.manifest_ver, manifest.movie_ver, manifest.sound_ver,
            manifest.resource[0], cacheDir);
    }

    public async Task ForceLogin()
    {
        if (!_logged && !_logging) await Login();
    }

}