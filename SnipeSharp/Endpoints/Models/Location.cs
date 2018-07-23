using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;
using System.Collections.Generic;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Location not found")]
    public class Location : CommonEndpointModel
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("address")]
        [OptionalRequestHeader("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        [OptionalRequestHeader("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        [OptionalRequestHeader("country")]
        public string Country { get; set; }

        [JsonProperty("zip")]
        [OptionalRequestHeader("zip")]
        public string Zip { get; set; }

        [JsonProperty("assets_count")]
        public long? AssetsCount { get; set; }

        [JsonProperty("users_count")]
        public long? UsersCount { get; set; }

        [JsonProperty("parent")]
        [OptionalRequestHeader("parent_id")]
        public Location Parent { get; set; }

        [JsonProperty("manager")]
        public User Manager { get; set; }

        [JsonProperty("children")]
        public List<Location> Children { get; set; }
    }
}
