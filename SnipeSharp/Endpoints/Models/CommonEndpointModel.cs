using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;
using SnipeSharp.Exceptions;
using SnipeSharp.JsonConverters;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Represents the the base of all objects we get back the API.  This is the building block for all more 
/// specific return objects. 
/// </summary>
namespace SnipeSharp.Endpoints.Models
{
    public class CommonEndpointModel : ICommonEndpointModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        [RequiredRequestHeader("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(ResponseDateTimeConverter))]
        public ResponseDate CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(ResponseDateTimeConverter))]
        public ResponseDate UpdatedAt { get; set; }

        // TODO - We're doing this so when it's passed in the header for create action we get the ID
        public override string ToString()
        {
            return Id.ToString();
        }

        /// <summary>
        /// Loop through all properties of this model, looking for any tagged with our custom attributes that we need
        /// to send as request headers
        /// </summary>
        /// <returns>Dictionary of header values</returns>
        public virtual Dictionary<string, string> BuildQueryString()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            // TODO: Revisit this.  Look at loop in SearchFilter
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                foreach (CustomAttributeData attData in prop.GetCustomAttributesData())
                {

                    string typeName = attData.Constructor.DeclaringType.Name;

                    if (typeName == "RequiredRequestHeader" || typeName == "OptionalRequestHeader")
                    {
                        var propValue = prop.GetValue(this)?.ToString();

                        // Abort in missing required headers
                        if (propValue == null && typeName == "RequiredRequestHeader")
                        {
                            throw new RequiredValueIsNullException(string.Format("{0} Cannot Be Null", prop.Name));
                        }

                        if (propValue != null)
                        {

                            string attName = attData.ConstructorArguments.First().ToString().Replace("\"", "");

                            values.Add(attName, propValue);
                        }
                    }
                }
            }

            return values;
        }
    }
}
