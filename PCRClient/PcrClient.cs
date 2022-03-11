using PCRClient.Models;
using PCRClient.Models.Db;

namespace PCRClient;

// behaviour level client

public class PcrClient : PcrClientSessionBase
{
    public async Task<ProfileGetResponse> GetProfile(long target)
    {
        return await Request(new ProfileGetRequest()
        {
            target_viewer_id = target
        });
    }

    public PcrClient(EnvironmentInfo info) : base(info)
    {
    }
}

public class AccountInfo
{
    public string? username, password;
    public int platform, channel;
}