using PCRClient.Models;
using PCRClient.Models.Db;

namespace PCRClient;

// behaviour level client

public class PcrClient : PcrClientBase
{
    public MasterContext? Database { get; private set; }
    
    public async Task Login(AccountInfo info)
    {
        await Prepare(info);
        var res = await BsGameSdk.Login(info, null!); 
        await Request(new ToolSdkLoginRequest()
        {
            uid = res.uid,
            access_key = res.access_key,
            platform = info.platform.ToString(),
            channel_id = info.channel.ToString()
        });
        await Request(new CheckGameStartRequest()
        {
            apptype = 0,
            campaign_data = string.Empty,
            campaign_user = new Random().Next(100000) & ~1
        });
        await Request(new CheckAgreementRequest());
        await Request(new LoadIndexRequest()
        {
            carrier = "OPPO"
        });
        await Request(new HomeIndexRequest()
        {
            message_id = 1,
            gold_history = 0,
            is_first = 1,
            tips_id_list = Array.Empty<int>()
        });
    }

    private static readonly int[] tutorialSteps =
    {
        1, 2, 3, 4, 5, 6, 7, 20, 30, 40, 50, 60, 100
    };

    public async Task SkipTutorial(string name = "\u4f51\u6811")
    {
        foreach (var step in tutorialSteps)
            await Request(new TutorialUpdateRequest()
            {
                step = step,
                skip = 0,
                user_name = name
            });
    }

    public async Task<ProfileGetResponse> GetProfile(long target)
    {
        return await Request(new ProfileGetRequest()
        {
            target_viewer_id = target
        });
    }

    public async Task<AssetManager> CreateAssetManager(string cacheDir = ".")
    {
        var manifest = await Request(new SourceIniGetMaintenanceStatusRequest());
        return await AssetManager.Create(manifest.manifest_ver, manifest.movie_ver, manifest.sound_ver,
            manifest.resource[0], cacheDir);
    }

    public async Task LoadDatabase(string cacheDir = ".") =>
        Database = await (await CreateAssetManager(cacheDir)).CreateMasterContext();

    public PcrClient(EnvironmentInfo info) : base(info)
    {
    }
}

public class AccountInfo
{
    public string? username, password;
    public int platform, channel;
}