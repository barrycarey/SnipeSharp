using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnipeSharp.Endpoints.Models;
using System;
using System.Collections.Generic;

namespace SnipeSharp.JsonConverters
{
    /// <summary>
    /// Since a returned object from any endpoint is represented by an ICommonResponseObject we need to figure out what the concrete type for
    /// the response needs to be. 
    /// 
    /// This class can return a single object or a list of objects depending if the passed in Jtoken is an object or array.
    /// </summary>
    public class DetectJsonObjectType : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            if (token.HasValues == false)
            {
                return null;
            }

            if (token.Type == JTokenType.Object)
            {
                return ResponsePayloadConverter.DetectObjectType(token);
            }

            if (token.Type == JTokenType.Array)
            {
                List<ICommonEndpointModel> final = new List<ICommonEndpointModel>();

                foreach (JToken item in token)
                {
                    ICommonEndpointModel result = ResponsePayloadConverter.DetectObjectType(item);
                    if (result != null) { final.Add(result); }
                }

                return final;
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
