using Newtonsoft.Json;
using PCRClient;

var client = new PcrClient(EnvironmentInfo.Default)
{
    Account = JsonConvert.DeserializeObject<AccountInfo>(File.ReadAllText("account.json"))
};

var profile = await client.GetProfile(1);