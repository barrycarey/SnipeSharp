using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.JsonConverters;

namespace SnipeSharp.Tests
{
    [TestClass]
    public class SnipeSharpTest
    {
        // Test object detection 
        [TestMethod]
        public void DeserializeAsset_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\asset.json");
            ICommonEndpointModel test = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(test, typeof(Asset));
        }

        [TestMethod]
        public void DeserializeModel_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\model.json");
            ICommonEndpointModel test = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(test, typeof(Model));
        }
    }
}
