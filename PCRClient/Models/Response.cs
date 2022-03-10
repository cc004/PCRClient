namespace PCRClient.Models;

public sealed class Response<T> where T : ResponseBase
{
    public ResponseHeader? data_headers;
    public T? data;
}