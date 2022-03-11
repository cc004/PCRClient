using Newtonsoft.Json;
using PCRClient;
using PCRClient.Models;

var accounts = JsonConvert.DeserializeObject<AccountInfo[]>(File.ReadAllText("accounts.json"))!;
var clients = new List<PcrClient>();

foreach (var account in accounts)
{
    var client = new PcrClient(EnvironmentInfo.Default)
    {
        Account = account,
        Validator = async captcha =>
        {
            await Task.Yield();
            Console.WriteLine($"https://help.tencentbot.top/geetest/?captcha_type=1&challenge={captcha.challenge}&gt={captcha.gt}&userid={captcha.gt_user_id}&gs=1");
            return captcha.CreateResult(Console.ReadLine() ?? string.Empty);
        }
    };
    clients.Add(client);
}

await clients[0].ForceLogin();
//Console.WriteLine((await clients[0].GetCurrentClanInfo()).members.Single(m => m.role == eClanRole.LEADER).viewer_id);