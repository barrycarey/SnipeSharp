using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public class Date
    {
        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("date")]
        public string DateObj { get; set; }
    }
}
