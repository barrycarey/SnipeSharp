using SnipeSharp.Common;
using Newtonsoft.Json;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Depreciation not found")]
    public class Depreciation : CommonEndpointModel
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
