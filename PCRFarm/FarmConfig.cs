using BandoriBot.Config;
using PCRClient;
#pragma warning disable CS8618

namespace PCRFarm;

public class FarmConfig : SerializableConfiguration<Config>
{
    public Farm farm;
    public override string Name => "farm_config.json";

    public override void LoadFrom(BinaryReader br)
    {
        base.LoadFrom(br);
        farm = new Farm(t);
        _ = Task.Run(farm.Start);
    }
}