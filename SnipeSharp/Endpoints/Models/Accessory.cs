using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Accessory not found")]
    public class Accessory : CommonEndpointModel
    {
        [JsonProperty("company")]
        [OptionalRequestHeader("company_id")]
        public Company Company { get; set; }

        [JsonProperty("manufacturer")]
        [OptionalRequestHeader("manufacturer_id")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("supplier")]
        [OptionalRequestHeader("supplier_id")]
        public Supplier Supplier { get; set; }

        [JsonProperty("model_number")]
        [OptionalRequestHeader("model_number")]
        public string ModelNumber { get; set; }        

        [JsonProperty("category")]
        [RequiredRequestHeader("category_id")]
        public Category Category { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [JsonProperty("notes")]
        [OptionalRequestHeader("notes")]
        public string Notes { get; set; }

        [JsonProperty("qty")]
        [RequiredRequestHeader("qty")]
        public long? Quantity { get; set; }

        [JsonProperty("purchase_date")]
        [OptionalRequestHeader("purchase_date")]
        public ResponseDate PurchaseDate { get; set; }

        [JsonProperty("purchase_cost")]
        [OptionalRequestHeader("purchase_cost")]
        public string PurchaseCost { get; set; }

        [JsonProperty("order_number")]
        [OptionalRequestHeader("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("min_qty")]
        [OptionalRequestHeader("min_qty")]
        public long? MinQty { get; set; }

        [JsonProperty("remaining_qty")]
        public long? RemainingQty { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user_can_checkout")]
        public bool UserCanCheckout { get; set; }
    }
}
