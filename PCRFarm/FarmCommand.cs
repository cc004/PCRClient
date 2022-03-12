using BandoriBot.Commands;
using BandoriBot.Config;
using PCRClient;
#pragma warning disable CS8618

namespace PCRFarm;

public class FarmCommand : ICommand
{
    public List<string> Alias => new() {"/farm"};
    public async Task Run(CommandArgs args)
    {
        var arg = args.Arg.Trim().Split(' ');
        switch (arg[0])
        {
            case "status":
                await args.Callback(Configuration.GetConfig<FarmConfig>().farm.GetStatus());
                break;
            case "invite":
                Configuration.GetConfig<FarmConfig>().farm.Invite(long.Parse(arg[1]));
                await args.Callback("已准备邀请");
                break;
            case "kick":
                Configuration.GetConfig<FarmConfig>().farm.Kick(long.Parse(arg[1]));
                await args.Callback("已准备踢出");
                break;
        }
    }
}