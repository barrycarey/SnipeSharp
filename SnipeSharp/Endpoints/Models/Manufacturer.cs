using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{

    [EndpointObjectNotFoundMessage("Manufacturer not found")]
    public class Manufacturer : CommonEndpointModel
    {
        [JsonProperty("url")]
        [OptionalRequestHeader("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("support_url")]
        [OptionalRequestHeader("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("support_phone")]
        [OptionalRequestHeader("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_email")]
        [OptionalRequestHeader("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("assets_count")]
        public long AssetsCount { get; set; }

        [JsonProperty("licenses_count")]
        public long LicensesCount { get; set; }

    }
}
