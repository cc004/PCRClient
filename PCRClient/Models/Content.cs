using System.Text;
using Newtonsoft.Json;

namespace PCRClient.Models;

[JsonObject]
public class Content
{
    public string url = string.Empty;
    public string? md5;
    public string type = string.Empty;
    public string? @class;
    public int size;
    private Content[] children = Array.Empty<Content>();
    [JsonProperty] private string[] children_json = Array.Empty<string>();

    public void UpdateChildren(IReadOnlyDictionary<string, Content> registries)
    {
        children = children_json.Select(u => registries[u]).ToArray();
    }

    private static readonly HttpClient client = new ();

    public bool IsAssets => type != "every";

    public Content(string url, string type, Content[] children)
    {
        this.url = url;
        this.type = type;
        this.children = children;
        children_json = children.Select(c => c.url).ToArray();
    }

    public Content()
    {
    }

    public static Content FromLine(string line, string? @class)
    {
        var splits = line.Split(',');
        return new Content(splits[0], splits[2], Array.Empty<Content>())
        {
            @class = @class,
            md5 = splits[1],
            size = int.Parse(splits[3]),
        };
    }

    public static async Task<Content[]> FromUrl(string urlroot, string url, string? @class)
    {
        Console.WriteLine($"downloading from {urlroot}{url}");
        var lines = (await client.GetStringAsync($"{urlroot}{url}")).Split('\n');
        var res = new Content[lines.Length];

        for (int i = 0; i < lines.Length; ++i)
        {
            res[i] = FromLine(lines[i], @class);
            await res[i].DownloadChildren(urlroot);
        }

        return res;
    }

    public async Task<byte[]> GetByteArray(Func<string, string> urlGetter, string? cache = null)
    {
        if (cache != null && File.Exists(cache))
        {
            var bytes = await File.ReadAllBytesAsync(cache);
            if (Utils.CalcMd5(bytes) == md5) return bytes;
        }

        if (md5 == null) return Array.Empty<byte>();
        var result = await client.GetByteArrayAsync(urlGetter(md5));
        if (cache != null) await File.WriteAllBytesAsync(cache, result);
        return result;
    }

    public async Task DownloadChildren(string urlroot)
    {
        if (IsAssets) return;

        children = await FromUrl(urlroot, url, @class);
        children_json = children.Select(c => c.url).ToArray();
    }

    public byte[] GenerateCsv()
    {
        return Encoding.UTF8.GetBytes(string.Join('\n', children.Select(c => c.GenerateLine())));
    }

    public string GenerateLine()
    {
        if (IsAssets) return $"{url},{md5},{type},{size},";

        var content = GenerateCsv();
        return $"{url},{Utils.CalcMd5(content)},every,{content.Length},";
    }

    public void RegisterTo(IContentHolder holder)
    {
        holder.RegisterContent(url, this);
        foreach (var child in children)
            child.RegisterTo(holder);
    }
}