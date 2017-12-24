using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnipeSharp.Common;

namespace SnipeSharp.JsonConverters
{
    /// <summary>
    /// Since we're building objects dynamicly based on API response we have to deal with 2 different formats used in the updated_at field and created_at field. 
    /// When doing a Get to request an object updated_at and created_at return an object containing a date and formatted string object.  However, if you create an object
    /// the API returns a single strings in the same field for the payload. 
    /// 
    /// -- Create or Update Payload -------------
    /// "updated_at": "2017-11-24 12:44:42",
    /// "created_at": "2017-11-24 12:44:42",
    /// 
    /// -- Get Response -------------------------
    /// "created_at": {
    ///    "datetime": "2017-11-24 11:46:36",
    ///    "formatted": "2017-11-24 11:46 AM"
    ///  },
    /// "updated_at": {
    ///    "datetime": "2017-11-24 11:57:08",
    ///    "formatted": "2017-11-24 11:57 AM"
    ///  },
    /// </summary>
    class ResponseDateTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.String)
            {
                return new ResponseDate()
                {
                    DateTime = token.ToObject<string>()
                };
            }

            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<ResponseDate>();
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
