using PCRClient;
#pragma warning disable CS8618

namespace PCRFarm;

public class Config
{
    public AccountInfo[] masters, workers;
    public int requestDelay = 60000;
    public string host;
}