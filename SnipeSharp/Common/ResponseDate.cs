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
        // TODO: Add logic to attempt to parse provided dates and put them in a format snipe can use. 
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
