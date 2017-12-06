using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;
using System.Net;

namespace SnipeSharp.Common
{
    class RequestManagerWebClient : IRequestManager
    {
        public RequestManagerWebClient(ApiSettings apiSettings)
        {
            _apiSettings = apiSettings;
        }

        public ApiSettings _apiSettings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string BuildBody()
        {
            throw new NotImplementedException();
        }

        public void CheckApiTokenAndUrl()
        {
            throw new NotImplementedException();
        }

        public string Checkin(string path)
        {
            throw new NotImplementedException();
        }

        public string Delete(string path)
        {
            throw new NotImplementedException();
        }

        public string Get(string path)
        {
            throw new NotImplementedException();
        }

        public string Get(string path, ISearchFilter filter)
        {
            throw new NotImplementedException();
        }

        public string Post(string path, ICommonEndpointModel item)
        {
            throw new NotImplementedException();
        }

        public string Put(string path, ICommonEndpointModel item)
        {
            throw new NotImplementedException();
        }

        public WebClient GetWebClient()
        {
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.Authorization] = "Bearer " + _apiSettings.ApiToken;
            client.Headers[HttpRequestHeader.Accept] = "application/json";

            return client;
        }
    }
}
