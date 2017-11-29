using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public class Message
    {
        [JsonProperty("name")]
        public List<string> Name { get; set; }

        [JsonProperty("general")]
        public List<string> General { get; set; }
    }
}
