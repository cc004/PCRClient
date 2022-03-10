using AssetsTools;
using Newtonsoft.Json;
using PCRClient.Models;
using PCRClient.Models.Db;

namespace PCRClient
{
    public interface IContentHolder
    {
        void RegisterContent(string url, Content content);
    }

    public class AssetManager : IContentHolder
    {
        public Dictionary<string, Content> registries = new ();
        private readonly string _cacheDir;

        public void RegisterContent(string url, Content content)
        {
            registries.Add(url, content);
        }
        
        private string Manifest => $"https://{Res}Manifest/";
        private string Pool => $"https://{Res}pool/";

        public string Ver { get; }
        public string Res { get; }

        public async Task AddRoot(string @class, string ver, string rootpath)
        {
            new Content(rootpath, "every", await Content.FromUrl($"{Manifest}{@class}/{ver}/", rootpath, @class))
                .RegisterTo(this);
        }

        private AssetManager(string ver, string res, string cacheDir)
        {
            Ver = ver;
            Res = res;
            _cacheDir = cacheDir;
        }

        internal static async Task<AssetManager> Create(string manifestVer, string movieVer, string soundVer, string res, string cacheDir)
        {
            var mgr = new AssetManager(manifestVer, res, cacheDir);
            try
            {
                mgr.registries =
                    JsonConvert.DeserializeObject<Dictionary<string, Content>>(
                        await File.ReadAllTextAsync(Path.Combine(cacheDir, $"manifest_{manifestVer}.json"))) ??
                    throw new InvalidOperationException();

                foreach (var (_, value) in mgr.registries)
                    value.UpdateChildren(mgr.registries);

                Console.WriteLine($"manifest version {manifestVer} loaded from cache");
            }
            catch (Exception e)
            {
                Console.WriteLine($"asset manager load cache failed for manifest version {manifestVer}");
                Console.WriteLine(e);

                await mgr.AddRoot("AssetBundles/Android", manifestVer, "manifest/manifest_assetmanifest");
                await mgr.AddRoot("Movie", movieVer + "/SP/High", "manifest/movie2manifest");
                await mgr.AddRoot("Sound", soundVer, "manifest/sound2manifest");

                await File.WriteAllTextAsync(Path.Combine(cacheDir, $"manifest_{manifestVer}.json"), JsonConvert.SerializeObject(mgr.registries));
            }

            return mgr;
        }

        public async Task<AssetBundleFile?> ResolveAssetsBundle(string path, string? cache = null)
        {
            if (registries.TryGetValue(path, out var content))
            {
                return AssetBundleFile.LoadFromMemory(
                    await content.GetByteArray(hash => $"{Pool}{content.@class}/{hash.Substring(0, 2)}/{hash}", cache)
                );
            }
            return null;
        }

        public async Task<MasterContext> CreateMasterContext()
        {
            var ab = await ResolveAssetsBundle("a/masterdata_master.unity3d", Path.Combine(_cacheDir, "master_data.unity3d"));
            if (ab == null) throw new InvalidOperationException();
            var af = ab.Files[0].ToAssetsFile();
            var dbdir = Path.Combine(_cacheDir, "master.db");
            await File.WriteAllBytesAsync(dbdir, af.Objects[0].Data.Skip(16).ToArray());
            return new MasterContext($"data source={dbdir}");
        }
    }
}
