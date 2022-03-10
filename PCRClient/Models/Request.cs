using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace PCRClient.Models
{
    public abstract class Request<T> where T : ResponseBase
    {
        [JsonProperty] private string? viewer_id;
        [JsonIgnore] internal virtual string Url => throw new NotImplementedException();
        [JsonIgnore] internal virtual bool Crypt => true;

        internal void ApplyViewerId(string id) => this.viewer_id = id;
    }

}
