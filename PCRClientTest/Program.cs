using PCRClient;

var client = new PcrClient(EnvironmentInfo.Default);
await client.Login(new AccountInfo()
{
    channel = 2,
    platform = 2,
});
var profile = await client.GetProfile(1);