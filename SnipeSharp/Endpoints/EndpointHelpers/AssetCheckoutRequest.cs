using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.Models;
using System;
using System.Linq;

namespace SnipeSharp.Endpoints.EndpointHelpers
{
    public class AssetCheckoutRequest
    {

        private string _checkoutToType;
        [RequiredRequestHeader("checkout_to_type")]
        public string CheckoutToType
        {
            get { return _checkoutToType; }
            set
            {
                string[] validTypes = { "location", "asset", "user" };
                if (validTypes.Contains(value.ToLower()))
                {
                    _checkoutToType = value;
                } else
                {
                    throw new NotSupportedException(string.Format("{0} is not a valid asset checkout type. Use {1}", value, string.Join(", ", validTypes)));
                }
            }
        }

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
