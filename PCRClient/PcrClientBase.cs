using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCRClient.Models;

namespace PCRClient;

// api-level client

public class PcrClientBase
{
    private readonly HttpClient _client;
    private string UrlRoot { get; set; } = "http://l3-prod-all-gs-gzlj.bilibiligame.net/";
    private long _viewerId;
    private string? _requestId;
    private string? _sessionId;

    protected PcrClientBase(EnvironmentInfo info)
    {
        _client = new HttpClient(new HttpClientHandler()
        {
            UseProxy = false,
            Proxy = null
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
        _viewerId = info.viewer_id;
    }

    protected async Task<T> Request<T>(Request<T> request) where T : ResponseBase
    {
        var key = PackHelper.CreateKey();
        request.ApplyViewerId(request.Crypt ? PackHelper.Encrypt(_viewerId.ToString(), key) : _viewerId.ToString());

        bool flag = _requestId != null, flag2 = _sessionId != null;
        if (flag) _client.DefaultRequestHeaders.TryAddWithoutValidation("REQUEST-ID", _requestId);
        if (flag2) _client.DefaultRequestHeaders.TryAddWithoutValidation("SID", _sessionId);

        var str = Encoding.UTF8.GetString(await (await _client.PostAsync(UrlRoot + request.Url,
                request.Crypt
                    ? new ByteArrayContent(PackHelper.Pack(JObject.FromObject(request), key))
                    : new StringContent(JsonConvert.SerializeObject(request))))
            .Content.ReadAsByteArrayAsync());

        if (flag) _client.DefaultRequestHeaders.Remove("REQUEST-ID");
        if (flag2) _client.DefaultRequestHeaders.Remove("SID");

        var response =
            (request.Crypt ? PackHelper.Unpack(Convert.FromBase64String(str), out _) : JObject.Parse(str))
            .ToObject<Response<T>>()
            ?? throw new ApiException<T>("response is null");

        if (response.data_headers == null)
            throw new ApiException<T>("header is null")
            {
                response = response
            };
        if (response.data == null)
            throw new ApiException<T>("data is null")
            {
                response = response
            };

        if (response.data_headers.sid != null)
        {
            using var md5 = MD5.Create();
            _sessionId = string.Concat(md5
                .ComputeHash(Encoding.UTF8.GetBytes(response.data_headers.sid + "c!SID!n"))
                .Select(b => b.ToString("x2")));
        }

        if (response.data_headers.request_id != null) _requestId = response.data_headers.request_id;
        if (response.data_headers.viewer_id != null) _viewerId = int.Parse(response.data_headers.viewer_id);

        if (response.data.server_error != null)
            throw new ApiException<T>(
                $"{response.data.server_error.title}: {response.data.server_error.message} (code = {response.data.server_error.status})")
            {
                response = response
            };

        return response.data;
    }
    protected async Task Prepare(AccountInfo info)
    {
        _client.DefaultRequestHeaders.TryAddWithoutValidation("PLATFORM", info.platform.ToString());
        _client.DefaultRequestHeaders.TryAddWithoutValidation("PLATFORM-ID", info.platform.ToString());
        _client.DefaultRequestHeaders.TryAddWithoutValidation("CHANNEL-ID", info.channel.ToString());
        UrlRoot = $"http://{(await Request(new SourceIniIndexRequest())).servers[0]}".Replace("\t", "");
        var manifest = await Request(new SourceIniGetMaintenanceStatusRequest());
        _client.DefaultRequestHeaders.TryAddWithoutValidation("MANIFEST-VER", manifest.required_manifest_ver);
    }
}