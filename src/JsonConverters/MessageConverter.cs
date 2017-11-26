using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SnipeSharp.JsonConverters
{
    /// <summary>
    /// Convert response messages to a dictionary matching the messages returned in Json
    /// </summary>
    class MessageConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();

            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.String)
            {
                results.Add("general", token.ToObject<string>());
            }

            if (token.Type == JTokenType.Object)
            {
                foreach (JProperty subToken in token)
                {
                    results.Add(subToken.Name, subToken.Value[0].ToString());

                }
            }

            return results;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
