using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnipeSharp.Exceptions;
using SnipeSharp.Common;
using System.Reflection;
using System.Net.Http;
using RestSharp;
using RestSharp.Authenticators;

namespace SnipeSharp.Tests
{
    [TestClass]
    public class RequestManagerTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullApiTokenException), "No API Token Set")]
        public void CheckApiTokenAndUrl_NoTokenInApiSettings_ThrowException()
        {
            SnipeItApi snipe = new SnipeItApi();
            snipe.ApiSettings.BaseUrl = new Uri("http://google.com");
            snipe.ReqManager.CheckApiTokenAndUrl();
        }

        [TestMethod]
        [ExpectedException(typeof(NullApiBaseUrlException), "No API Base Url Set.")]
        public void CheckApiTokenAndUrl_NoUrlInApiSettings_ThrowException()
        {
            SnipeItApi snipe = new SnipeItApi();
            snipe.ApiSettings.ApiToken = "xxxxx";
            snipe.ReqManager.CheckApiTokenAndUrl();
        }

        [TestMethod]
        public void CheckApiTokenAndUrl_SetHttpClientBaseAddress_SetCorrectly()
        {
            var snipe = new SnipeItApi();
            var url = new Uri("http://google.com");
            snipe.ApiSettings.ApiToken = "xxxxx";
            snipe.ApiSettings.BaseUrl = url;
            snipe.ReqManager.CheckApiTokenAndUrl();

            // Get the Static property value
            var prop = typeof(RequestManagerRestSharp).GetField("Client", BindingFlags.NonPublic | BindingFlags.Static);
            var client = prop.GetValue(snipe.ReqManager) as RestClient;

            Assert.AreEqual<Uri>(url, client.BaseUrl);
        }

        [TestMethod]
        public void CheckApiTokenAndUrl_SetAuthorizationHeader_SetCorrectly()
        {
            var snipe = new SnipeItApi();
            var url = new Uri("http://google.com");
            snipe.ApiSettings.ApiToken = "xxxxx";
            snipe.ApiSettings.BaseUrl = url;
            snipe.ReqManager.CheckApiTokenAndUrl();

            // Get the Static property value
            var prop = typeof(RequestManagerRestSharp).GetField("Client", BindingFlags.NonPublic | BindingFlags.Static);
            var client = prop.GetValue(snipe.ReqManager) as RestClient;

            // NOTE: This test depends on the internal implementation of RestSharp not changing. Check there if you update that dependency!
            var value = new PrivateObject(client.Authenticator).GetField("authorizationValue") as string;
            
            Assert.AreEqual<string>("Bearer xxxxx", value);
        }
    }
}
