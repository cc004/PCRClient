using Newtonsoft.Json;
using PCRClient;

var accounts = JsonConvert.DeserializeObject<AccountInfo[]>(File.ReadAllText("accounts.json"))!;
var clients = new List<PcrClient>();

foreach (var account in accounts.Skip(1).Take(2))
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

var requests = await clients[0].GetEquipmentRequests();
await clients[1].DonateEquip(requests[0], 1);
await clients[1].DonateEquip(requests[0], 1);
Console.ReadLine();
await clients[1].DonateEquip(requests[0], 1);