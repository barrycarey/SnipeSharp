using Newtonsoft.Json;
using SnipeSharp.Attributes;
using System.Linq;
using SnipeSharp.Exceptions;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Category not found")]
    public class Category : CommonEndpointModel
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        private string _type;

        [JsonProperty("type")]
        [RequiredRequestHeader("category_type")]
        public string Type
        { // TODO: We should probably remove this and rely on the API to say it's invalid
            get { return _type; }
            set
            {
                // TODO: Move this logic somewhere else
                string[] validTypes = { "asset", "accessory", "consumable", "component" };
                if (validTypes.Contains(value.ToLower()))
                {
                    _type = value;
                }
                else
                {
                    throw new InvalidCategoryTypeException(string.Format("{0} Is an invalid category type.  Use {1}", value, string.Join(", ", validTypes)));
                }
            }
        }

        [JsonProperty("eula")]
        [OptionalRequestHeader("eula")]
        public bool eula { get; set; }

        [JsonProperty("checkin_email")]
        [OptionalRequestHeader("checkin_email")]
        public bool CheckinEmail { get; set; }

        [JsonProperty("require_acceptance")]
        [OptionalRequestHeader("required_acceptance")]
        public bool RequireAcceptance { get; set; }

        [JsonProperty("assets_count")]
        public long? AssetsCount { get; set; }

        [JsonProperty("accessories_count")]
        public long? AccessoriesCount { get; set; }

        [JsonProperty("consumables_count")]
        public long? ConsumablesCount { get; set; }

        [JsonProperty("components_count")]
        public long? ComponentsCount { get; set; }


    }
}
