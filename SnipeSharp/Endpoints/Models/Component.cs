using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.Models
{
    [EndpointObjectNotFoundMessage("Component not found")]
    public class Component : CommonEndpointModel
    {
        [JsonProperty("serial_number")]
        [OptionalRequestHeader("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [JsonProperty("qty")]
        [RequiredRequestHeader("qty")]
        public long? Quantity { get; set; }

        [JsonProperty("min_amt")]
        [OptionalRequestHeader("min_amt")]
        public long? MinAmt { get; set; }

        [JsonProperty("category")]
        [RequiredRequestHeader("category_id")]
        public Category Category { get; set; }

        [JsonProperty("order_number")]
        [OptionalRequestHeader("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("purchase_date")]
        [OptionalRequestHeader("purchase_date")]
        public ResponseDate PurchaseDate { get; set; }

        [JsonProperty("purchase_cost")]
        [OptionalRequestHeader("purchase_cost")]
        public string PurchaseCost { get; set; }

        [JsonProperty("remaining")]
        public long? Remaining { get; set; }

        [JsonProperty("company")]
        [OptionalRequestHeader("company_id")]
        public Company Company { get; set; }

        [JsonProperty("user_can_checkout")]
        public bool UserCanCheckout { get; set; }
    }
}
