using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// The base class for all SearchFilter objects.  These properties are common to any filter we want to do on a get request for all endpoints.
/// </summary>
namespace SnipeSharp.Endpoints.SearchFilters
{
    public class SearchFilter : ISearchFilter
    {
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        public string Search { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }

        public Dictionary<string, string> GetQueryString()
        {
            string queryString = "";
            Dictionary<string, string> urlParams = new Dictionary<string, string>();

            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                
                var propValue = prop.GetValue(this)?.ToString();

                if (propValue == null) continue;

                var result = prop.GetCustomAttributesData()
                                .Where(p => p.Constructor.DeclaringType.Name == "FilterParamName")
                                    .FirstOrDefault();

                // If there's no custom filter param name attrb use the default property name
                // TODO: I think this is grabbing all properties regardless of if they're flagged
                // Check and see if we are getting all props or just flagged ones
                string keyName = (result != null) ? result.ConstructorArguments
                                                                            .First()
                                                                                .ToString()
                                                                                    .Replace("\"", "")
                                                                                    .ToLower() : prop.Name.ToLower();

                urlParams.Add(keyName, propValue);

            }

            return urlParams;

        }

    }
}
