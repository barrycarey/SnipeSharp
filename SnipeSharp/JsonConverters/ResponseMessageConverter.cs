using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnipeSharp.Common;

namespace SnipeSharp.JsonConverters
{
    public class ResponseMessageConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {           
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<Message>();
            }

            if (token.Type == JTokenType.String)
            {
                Message message = new Message()
                {
                    General = new List<string>()
                    {
                        token.ToObject<string>()
                    }
                };

                return message;
            }

            return new object();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
