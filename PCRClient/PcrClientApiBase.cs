using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCRClient.Models;

namespace PCRClient;

public class PcrClientApiBase
{
    private readonly HttpClient _client;
    private string UrlRoot { get; set; } = "http://l3-prod-all-gs-gzlj.bilibiligame.net/";
    public long ViewerId { get; private set; }
    private string? _requestId;
    private string? _sessionId;
    
    protected PcrClientApiBase(EnvironmentInfo? info = null)
    {
        info ??= EnvironmentInfo.Default;

        _client = new HttpClient(new HttpClientHandler
        {
            //UseProxy = false,
            //Proxy = null
        });
        _client.DefaultRequestHeaders.Clear();
        foreach (var field in typeof(EnvironmentInfo).GetFields())
        {
            if (field.FieldType != typeof(string)) continue;
            _client.DefaultRequestHeaders.TryAddWithoutValidation(
                field.IsDefined(typeof(NoUpperAttribute), true)
                    ? field.Name.Replace('_', '-')
                    : field.Name.Replace('_', '-').ToUpper(),
                field.GetValue(info) as string);
        }

        _client.DefaultRequestHeaders.TryAddWithoutValidation("Connection", "Keep-Alive");
        ViewerId = info.viewer_id;
    }

    protected virtual async Task<T> Request<T>(Request<T> request) where T : ResponseBase
    {
        var key = PackHelper.CreateKey();
        request.ApplyViewerId(request.Crypt ? PackHelper.Encrypt(ViewerId.ToString(), key) : ViewerId.ToString());
        
        if (!string.IsNullOrEmpty(_requestId)) _client.DefaultRequestHeaders.TryAddWithoutValidation("REQUEST-ID", _requestId);
        if (!string.IsNullOrEmpty(_sessionId)) _client.DefaultRequestHeaders.TryAddWithoutValidation("SID", _sessionId);

        var str = Encoding.UTF8.GetString(await (await _client.PostAsync(UrlRoot + request.Url,
                request.Crypt
                    ? new ByteArrayContent(PackHelper.Pack(JObject.FromObject(request), key))
                    : new StringContent(JsonConvert.SerializeObject(request))))
            .Content.ReadAsByteArrayAsync());

        _client.DefaultRequestHeaders.Remove("REQUEST-ID");
        _client.DefaultRequestHeaders.Remove("SID");

        var response =
            (request.Crypt ? PackHelper.Unpack(Convert.FromBase64String(str), out _) : JObject.Parse(str))
            .ToObject<Response<T>>()
            ?? throw new ApiException<T>("response is null");

        if (response.data_headers == null)
            throw new ApiException<T>("header is null")
            {
                response = response
            };

        if (!string.IsNullOrEmpty(response.data_headers.sid))
        {
            using var md5 = MD5.Create();
            _sessionId = string.Concat(md5
                .ComputeHash(Encoding.UTF8.GetBytes(response.data_headers.sid + "c!SID!n"))
                .Select(b => b.ToString("x2")));
        }

        if (!string.IsNullOrEmpty(response.data_headers.request_id)) _requestId = response.data_headers.request_id;
        if (!string.IsNullOrEmpty(response.data_headers.viewer_id)) ViewerId = long.Parse(response.data_headers.viewer_id);

        if (response.data?.server_error != null)
        {
            Log(LogLevel.Error,
                $"[{typeof(T).Name}] {response.data.server_error.title}: {response.data.server_error.message} (code = {response.data.server_error.status})");
            throw new ApiException<T>(
                $"{response.data.server_error.title}: {response.data.server_error.message} (code = {response.data.server_error.status})")
            {
                response = response
            };
        }

        Log(LogLevel.Info, typeof(T).Name);
        return response.data!;
    }

    protected async Task<SourceIniGetMaintenanceStatusResponse> Prepare(AccountInfo info)
    {
        _client.DefaultRequestHeaders.Remove("PLATFORM");
        _client.DefaultRequestHeaders.Remove("PLATFORM-ID");
        _client.DefaultRequestHeaders.Remove("CHANNEL-ID");

        _client.DefaultRequestHeaders.TryAddWithoutValidation("PLATFORM", info.platform.ToString());
        _client.DefaultRequestHeaders.TryAddWithoutValidation("PLATFORM-ID", info.platform.ToString());
        _client.DefaultRequestHeaders.TryAddWithoutValidation("CHANNEL-ID", info.channel.ToString());
        UrlRoot = $"http://{(await Request(new SourceIniIndexRequest())).server[0]}".Replace("\t", "");

        var manifest = await Request(new SourceIniGetMaintenanceStatusRequest());
        _client.DefaultRequestHeaders.Remove("MANIFEST-VER");
        _client.DefaultRequestHeaders.TryAddWithoutValidation("MANIFEST-VER", manifest.required_manifest_ver);
        return manifest;
    }

    protected enum LogLevel
    {
        Info = 0,
        Error = 1
    }

    /// <summary>
    /// null value disables logging
    /// </summary>

    protected virtual void Log(LogLevel level, string message)
    {
        Console.WriteLine($"[{level.ToString().ToLower()}] {message}");
    }

    //public static implicit operator long(PcrClientApiBase self) => self.ViewerId;
}