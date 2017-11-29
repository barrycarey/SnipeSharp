using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public class ApiSettings
    {
        private string _apiToken;
        public string ApiToken
        {
            get
            {
                return _apiToken;
            }
            set
            {
                _apiToken = value;
            }
        }

        private Uri _baseUrl;
        public Uri BaseUrl
        {
            get
            {
                return _baseUrl;
            }
            set
            {
                _baseUrl = value;
            }
        }



        public ApiSettings()
        {
        }
    }
}
