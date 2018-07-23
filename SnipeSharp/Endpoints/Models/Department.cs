using SnipeSharp.Common;
using Newtonsoft.Json;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Department not found")]
    public class Department : CommonEndpointModel
    {
        [JsonProperty("company_id")]
        [OptionalRequestHeader("company_id")]
        public Company Company { get; set; }

        [JsonProperty("manager")]
        [OptionalRequestHeader("manager_id")]
        public User Manager { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }
    }
}
