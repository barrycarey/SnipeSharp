using Newtonsoft.Json;
using SnipeSharp.JsonConverters;
using System.Collections.Generic;

namespace SnipeSharp.Common
{
    public class ResultsRow : IResponseCollection
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("rows")]
        [JsonConverter(typeof(DetectJsonObjectType))]
        public List<ICommonEndpointObject> Rows { get; set; }
    }
}
