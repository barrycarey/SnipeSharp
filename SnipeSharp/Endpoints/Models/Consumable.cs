using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Consumable not found")]
    public class Consumable : CommonEndpointModel
    {
        [JsonProperty("category")]
        [RequiredRequestHeader("category_id")]
        public Category Category { get; set; }

        [JsonProperty("company")]
        [OptionalRequestHeader("company_id")]
        public Company Company { get; set; }

        [JsonProperty("item_no")]
        [OptionalRequestHeader("item_no")]
        public string ItemNo { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [JsonProperty("manufacturer")]
        [OptionalRequestHeader("manufacturer_id")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("min_amt")]
        [OptionalRequestHeader("min_amt")]
        public long? MinAmt { get; set; }

        [JsonProperty("model_number")]
        [OptionalRequestHeader("model_number")]
        public string ModelNumber { get; set; }

        [JsonProperty("remaining")]
        [OptionalRequestHeader("remaining")]
        public long? Remaining { get; set; }

        [JsonProperty("order_number")]
        [OptionalRequestHeader("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("purchase_cost")]
        [OptionalRequestHeader("purchase_cost")]
        public string PurchaseCost { get; set; }

        [JsonProperty("purchase_date")]
        [OptionalRequestHeader("purchase_date")]
        public ResponseDate PurchaseDate { get; set; }

        [JsonProperty("qty")]
        [RequiredRequestHeader("qty")]
        public long? Quantity { get; set; }

        [JsonProperty("user_can_checkout")]
        public bool UserCanCheckout { get; set; }
    }
}
