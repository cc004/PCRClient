namespace PCRClient.Models;

public sealed class ResponseHeader
{
    public string? sid, request_id, viewer_id;
    public long servertime;
    public int result_code;
    public bool short_udid;
}