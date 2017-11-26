using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public class ResponseDate
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        public override string ToString()
        {
            return Date;
        }
    }
}
