using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.Models;
using System;
using System.Linq;

namespace SnipeSharp.Endpoints.EndpointHelpers
{
    public class AssetCheckoutRequest
    {

        [OptionalRequestHeader("checkout_to_type")]
        public string CheckoutToType { get; set; }

        [OptionalRequestHeader("assigned_location")]
        public Location AssignedLocation { get; set; }

        [OptionalRequestHeader("assigned_asset")]
        public Asset AssignedAsset { get; set; }

        [OptionalRequestHeader("assigned_user")]
        public User AssignedUser { get; set; }

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
