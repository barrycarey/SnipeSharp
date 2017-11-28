using Newtonsoft.Json;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.JsonConverters;
using System.Collections.Generic;
using System.Linq;

namespace SnipeSharp.Common
{
    public class RequestResponse : IRequestResponse
    {

        [JsonProperty("messages")]
        [JsonConverter(typeof(MessageConverter))]
        public Dictionary<string, string> Messages { get; set; }

        [JsonProperty("payload")]
        [JsonConverter(typeof(DetectJsonObjectType))]
        public ICommonEndpointModel Payload { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Status, Messages.First().Value);
        }
    }
}
