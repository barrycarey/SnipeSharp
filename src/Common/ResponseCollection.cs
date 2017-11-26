using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public class ResponseCollection : IResponseCollection
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("rows")]
        public List<ICommonEndpointObject> Rows { get; set; }
    }
}
