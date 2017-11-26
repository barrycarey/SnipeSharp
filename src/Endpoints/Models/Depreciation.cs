using SnipeSharp.Common;
using Newtonsoft.Json;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    public class Depreciation : CommonEndpointObject
    {

        private string _months;

        [JsonProperty("months")]
        [RequiredRequestHeader("months")]
        public string Months
        {
            get
            {
                return _months;
            }
            set
            {
                _months = (value != null) ? value : null;
            }
        }

    }
}
