using Newtonsoft.Json;

namespace SnipeSharp.Common
{
    public class ResponseDate
    {
        // TODO: Add logic to attempt to parse provided dates and put them in a format snipe can use. 
        [JsonProperty("datetime")]
        public string DateTime { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        public override string ToString()
        {
            return DateTime;
        }
    }
}
