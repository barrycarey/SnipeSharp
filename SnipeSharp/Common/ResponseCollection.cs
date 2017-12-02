using Newtonsoft.Json;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.JsonConverters;
using System.Collections.Generic;

namespace SnipeSharp.Common
{
    public class ResponseCollection<T> : IResponseCollection<T>
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("rows")]
        //[JsonConverter(typeof(DetectJsonObjectType))]
        public List<T> Rows { get; set; }
    }
}
