using Newtonsoft.Json;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{
    public class License : CommonEndpointModel
    {
 
        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("expiration_date")]
        public Date ExpirationDate { get; set; }

        [JsonProperty("free_seats_count")]
        public long? FreeSeatsCount { get; set; }

        [JsonProperty("license_email")]
        public string LicenseEmail { get; set; }

        [JsonProperty("license_name")]
        public string LicenseName { get; set; }

        [JsonProperty("maintained")]
        public bool Maintained { get; set; }

        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("product_key")]
        public string ProductKey { get; set; }

        [JsonProperty("purchase_cost")]
        public string PurchaseCost { get; set; }

        [JsonProperty("purchase_date")]
        public Date PurchaseDate { get; set; }

        [JsonProperty("purchase_order")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("seats")]
        public long Seats { get; set; }

        [JsonProperty("supplier")]
        public Company Supplier { get; set; }

        [JsonProperty("user_can_checkout")]
        public bool UserCanCheckout { get; set; }
    }
}
