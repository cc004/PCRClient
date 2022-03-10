using PCRClient.Models;

namespace PCRClient;

public abstract class ApiException : Exception
{
    protected ApiException()
    {
    }

    protected ApiException(string message) : base(message)
    {
    }

    protected ApiException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

[Serializable]
public class ApiException<T> : ApiException where T : ResponseBase
{
    public Response<T>? response;

    public ApiException()
    {
    }

    public ApiException(string message) : base(message)
    {
    }

    public ApiException(string message, Exception innerException) : base(message, innerException)
    {
    }
}