using Newtonsoft.Json.Linq;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.Exceptions;
using System.Collections.Generic;

namespace SnipeSharp.JsonConverters
{
    public static class ResponsePayloadConverter
    {
        /// <summary>
        /// Since all possible objects returned from Get requests to the API and considered ICommonResponseObjects we need a way to match the 
        /// JSON object to a concrete type so Json.net can convert the Json object to the real object. 
        /// 
        /// Most of the different endpoint objects have at least 1 unique value.  We just need to look for those unique values and trigger on them.
        /// </summary>
        /// <param name="item">JToken object of the JSON to check</param>
        /// <returns></returns>
        public static ICommonEndpointModel DetectObjectType(JToken item)
        {

            // TODO: This is hackish.  If we request an ID that doesn't exist the API sends back a response in RequestResponse format instead of the object format. 
            // There's probably a better way to deal with this case.  Will deal with it later.  For now we're shoe horning an IRequestResponse into an ICommonResponseObject
            if (item.Type != JTokenType.Array && item.Value<string>("status") != null)
            {
                CommonEndpointModel result = new CommonEndpointModel()
                {
                    Name = string.Format("ERROR: {0}", item.Value<string>("messages"))
                };

                return result;
            }

            // Convert to dict so we can easily check if keys exist
            IDictionary<string, JToken> dictionary = (JObject)item;          

            // Manufacturer
            if (dictionary.ContainsKey("support_url"))
            {
                return item.ToObject<Manufacturer>();
            }

            // Category
            if (dictionary.ContainsKey("eula"))
            {
                return item.ToObject<Category>();
            }

            // Status Label
            if (dictionary.ContainsKey("show_in_nav"))
            {
                return item.ToObject<StatusLabel>();
            }

            // Model
            if (dictionary.ContainsKey("eol"))
            {
                return item.ToObject<Model>();
            }

            //Asset
            if (dictionary.ContainsKey("asset_tag"))
            {
                return item.ToObject<Asset>();
            }

            // User
            if (dictionary.ContainsKey("username"))
            {
                return item.ToObject<User>();
            }

            // Location
            if (dictionary.ContainsKey("parent") && dictionary.ContainsKey("children"))
            {
                return item.ToObject<Location>();
            }

            if (dictionary.ContainsKey("company") && dictionary.ContainsKey("manager"))
            {
                return item.ToObject<Department>();
            }

            // Company
            if (dictionary.ContainsKey("users_count"))
            {
                return item.ToObject<Company>();
            }

            // Supplier
            if (dictionary.ContainsKey("fax"))
            {
                return item.ToObject<Supplier>();
            }

            // License
            if (dictionary.ContainsKey("seats"))
            {
                return item.ToObject<License>();
            }

            // Consumable
            // TODO: This isn't great since I think it's based on a type in the API
            if (dictionary.ContainsKey("min_amt") && dictionary.ContainsKey("model_number"))
            {
                return item.ToObject<Consumable>();
            }

            // Component
            // TODO: This isn't great since I think it's based on a type in the API
            if (dictionary.ContainsKey("min_amt") && dictionary.ContainsKey("serial_number"))
            {
                return item.ToObject<Component>();
            }

            // Accessories
            // TODO: This isn't great since I think it's based on a type in the API
            if (dictionary.ContainsKey("min_qty") && dictionary.ContainsKey("remaining_qty"))
            {
                return item.ToObject<Accessory>();
            }

            return item.ToObject<CommonEndpointModel>();
            //throw new FailedToDetectObjectException();

        }
    }
}
