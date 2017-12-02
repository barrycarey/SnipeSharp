using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;
using SnipeSharp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;

namespace SnipeSharp.Common
{

    // TODO: Do async properly.  This is deadlocking and useless right now
    public class RequestManager : IRequestManager
    {

        public ApiSettings _apiSettings { get; set; }
        static HttpClient Client;

        public RequestManager(ApiSettings apiSettings)
        {
            _apiSettings = apiSettings;
            Client = new HttpClient();
            Client.BaseAddress = _apiSettings.BaseUrl;
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }        

        public string BuildBody()
        {
            throw new NotImplementedException();
        }

        public string Delete(string path)
        {

            CheckApiTokenAndUrl();

            string result = "";
            HttpResponseMessage response = Client.DeleteAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public string Get(string path)
        {

            CheckApiTokenAndUrl();

            string result = "";
            HttpResponseMessage response = Client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;                
            }

            return result;
        }

        public string Get(string path, ISearchFilter filter)
        {
            CheckApiTokenAndUrl();
            path = path + "?" + filter.GetQueryString();
            string result = "";

            HttpResponseMessage response = Client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public string Post(string path, ICommonEndpointModel item)
        {

            CheckApiTokenAndUrl();

            HttpResponseMessage response = Client.PostAsync(path, BuildQueryString(item)).Result;
            string result = null;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public string Put(string path, ICommonEndpointModel item)
        {

            CheckApiTokenAndUrl();

            HttpResponseMessage response = Client.PutAsync(path, BuildQueryString(item)).Result;
            string result = null;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        // TODO: This is a temp fix untl I can find a better way to deal with Checkin/Checkout
        public string Checkin(string path)
        {
            HttpResponseMessage response = Client.PostAsync(path, null).Result;
            string result = null;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public FormUrlEncodedContent BuildQueryString(ICommonEndpointModel item)
        {

            Dictionary<string, string> values = new Dictionary<string, string>();

            // If it's an asset check if there's a checkout request.  Also process custom fields
            // TODO: Not sure I like doing it like this.  Maybe add method to Asset
            // TODO: I REALLY don't like doing it this way
            Asset asset = item as Asset;
            if (asset != null)
            {
                // If an asset as this set we know it needs to be check out. 
                if (asset.CheckoutRequest != null)
                {
                    foreach (PropertyInfo prop in asset.CheckoutRequest.GetType().GetProperties())
                    {
                        var propValue = (prop.GetValue(asset.CheckoutRequest) != null) ? prop.GetValue(asset.CheckoutRequest).ToString() : null;

                        if (propValue == null) continue;

                        var result = prop.GetCustomAttributesData()
                                        .Where(p => p.Constructor.DeclaringType.Name == "OptionalRequestHeader")
                                            .FirstOrDefault();

                        if (result == null) continue;

                        string keyname = result.ConstructorArguments.First().ToString().Replace("\"", "").ToLower();

                        values.Add(keyname, propValue);
                    }

                    return new FormUrlEncodedContent(values);
                }

                // Assets are the only ones that have custom fields
                if (asset != null && asset.CustomFields != null)
                {
                    foreach (KeyValuePair<string, string> custField in asset.CustomFields)
                    {
                        values.Add(custField.Key, custField.Value);
                    }
                }
            }
            

            // TODO: Revisit this.  Look at loop in SearchFilter
            foreach (PropertyInfo prop in item.GetType().GetProperties())
            {
                foreach (CustomAttributeData attData in prop.GetCustomAttributesData())
                {
                    
                    string typeName = attData.Constructor.DeclaringType.Name;

                    if (typeName == "RequiredRequestHeader" || typeName == "OptionalRequestHeader")
                    {
                        var propValue = prop.GetValue(item);

                        // Abort in missing required headers
                        if (propValue == null && typeName == "RequiredRequestHeader")
                        {
                            throw new RequiredValueIsNullException(string.Format("{0} Cannot Be Null", prop.Name));
                        }

                        if (propValue != null)
                        {
                            
                            string attName = attData.ConstructorArguments.First().ToString().Replace("\"", "");

                            values.Add(attName, propValue.ToString());
                        }                        
                    } 
                }
            }

            

            FormUrlEncodedContent content = new FormUrlEncodedContent(values);

            return content;
        }

        // Since the Token and URL can be set anytime after the SnipApi object is created we need to check for these before sending a request
        public void CheckApiTokenAndUrl()
        {
            if (_apiSettings.BaseUrl == null)
            {
                throw new NullApiBaseUrlException("No API Base Url Set.");
            }

            if (_apiSettings.ApiToken == null)
            {
                throw new NullApiTokenException("No API Token Set");
            }

            if (Client.BaseAddress == null)
            {
                Client.BaseAddress = _apiSettings.BaseUrl;
            }

            if (Client.DefaultRequestHeaders.Authorization == null)
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiSettings.ApiToken);
            }
        }


    }
}
