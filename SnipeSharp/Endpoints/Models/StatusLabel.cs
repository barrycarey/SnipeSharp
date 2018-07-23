using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;
using System.Linq;
using SnipeSharp.Exceptions;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Statuslabel not found")]
    public class StatusLabel : CommonEndpointModel
    {
        private string _type;

        [JsonProperty("type")]
        [RequiredRequestHeader("type")]
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                // TODO: Move this logic somewhere else
                string[] validTypes = { "deployable", "pending", "archived" };
                if (validTypes.Contains(value.ToLower()))
                {
                    _type = value;
                } else
                {
                    throw new InvalidStatusLabelTypeException(string.Format("{0} Is an invalid status lable.  Use {1}", value, string.Join(", ", validTypes)));
                }
            }
        }

        [JsonProperty("color")]
        [OptionalRequestHeader("color")]
        public string Color { get; set; }

        [JsonProperty("show_in_nav")]
        [OptionalRequestHeader("show_in_nav")]
        public bool ShowInNav { get; set; }

        [JsonProperty("assets_count")]
        public long? AssetsCount { get; set; }

        [JsonProperty("notes")]
        [OptionalRequestHeader("notes")]
        public string Notes { get; set; }

        [RequiredRequestHeader("deployable")]
        public bool Deployable { get; set; }

        [RequiredRequestHeader("pending")]
        public bool Pending { get; set; }

        [RequiredRequestHeader("archived")]
        public bool Archived { get; set; }
    }
}
