using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;
using SnipeSharp.JsonConverters;

/// <summary>
/// Represents the the base of all objects we get back the API.  This is the building block for all more 
/// specific return objects. 
/// </summary>
namespace SnipeSharp.Endpoints.Models
{
    public class CommonEndpointModel : ICommonEndpointModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        [RequiredRequestHeader("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(ResponseDateTimeConverter))]
        public ResponseDate CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(ResponseDateTimeConverter))]
        public ResponseDate UpdatedAt { get; set; }

        // TODO - We're doing this so when it's passed in the header for create action we get the ID
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
