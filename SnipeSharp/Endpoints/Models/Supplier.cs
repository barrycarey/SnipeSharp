using SnipeSharp.Common;
using Newtonsoft.Json;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Supplier not found")]
    public class Supplier : CommonEndpointModel
    {
        [JsonProperty("name")]
        [OptionalRequestHeader("name")]
        public new string Name { get; set; }

        [OptionalRequestHeader("address")]
        [JsonProperty("address")]
        public string Address { get; set; }

        [OptionalRequestHeader("city")]
        [JsonProperty("city")]
        public string City { get; set; }

        [OptionalRequestHeader("state")]
        [JsonProperty("state")]
        public string State { get; set; }

        [OptionalRequestHeader("country")]
        [JsonProperty("country")]
        public string Country { get; set; }

        [OptionalRequestHeader("zip")]
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [OptionalRequestHeader("fax")]
        [JsonProperty("fax")]
        public string Fax { get; set; }

        [OptionalRequestHeader("phone")]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [OptionalRequestHeader("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [OptionalRequestHeader("contact")]
        [JsonProperty("contact")]
        public string Contact { get; set; }

        [OptionalRequestHeader("notes")]
        [JsonProperty("notes")]
        public string Notes { get; set; }

    }
}
