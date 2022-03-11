using Newtonsoft.Json;
using PCRFarm;

var farm = new Farm(JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"))!);
await farm.Start();

for (;;)
{
    farm.Invite(long.Parse(Console.ReadLine()!));
}