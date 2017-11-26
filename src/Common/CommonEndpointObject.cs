using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.JsonConverters;


namespace SnipeSharp.Common
{
    public class CommonEndpointObject : ICommonEndpointObject
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
