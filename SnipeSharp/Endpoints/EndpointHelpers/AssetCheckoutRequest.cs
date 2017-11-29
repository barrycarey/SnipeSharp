using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.EndpointHelpers
{
    public class AssetCheckoutRequest
    {

        [OptionalRequestHeader("user_id")]
        public User User { get; set; }

        [OptionalRequestHeader("asset_id")]
        public int? AssetId { get; set; }

        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [OptionalRequestHeader("note")]
        public string Note { get; set; }

        [OptionalRequestHeader("expected_checkin")]
        public string ExpectedCheckin { get; set; } // TODO: Make this a date object

        [OptionalRequestHeader("checkout_at")]
        public string CheckoutAt { get; set; }  // TODO: Make this a date object

        [OptionalRequestHeader("name")]
        public string Name { get; set; }


    }
}
