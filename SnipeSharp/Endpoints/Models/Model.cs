using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("AssetModel not found")]
    public class Model : CommonEndpointModel
    {

        [JsonProperty("manufacturer")]
        [RequiredRequestHeader("manufacturer_id")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("category")]
        [RequiredRequestHeader("category_id")]
        public Category Category { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("model_number")]
        [OptionalRequestHeader("model_number")]
        public string ModelNumber { get; set; }

        [JsonProperty("depreciation")]
        [OptionalRequestHeader("depreciation_id")]
        public Depreciation Depreciation { get; set; }

        [JsonProperty("assets_count")]
        public long AssetsCount { get; set; }

        [JsonProperty("eol")]
        [OptionalRequestHeader("eol")]
        public string Eol { get; set; }

        [JsonProperty("notes")]
        [OptionalRequestHeader("notes")]
        public string Notes { get; set; }

        [JsonProperty("fieldset")]
        [OptionalRequestHeader("fieldset_id")]
        public FieldSet FieldSet { get; set; }

        [JsonProperty("deleted_at")]
        public ResponseDate DeletedAt { get; set; }

    }
}
