using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.JsonConverters;

namespace SnipeSharp.Tests
{
    [TestClass]
    public class DeserializationDetection
    {
        // Test object detection 
        [TestMethod]
        public void DeserializeAsset_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\asset.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Asset));
        }

        [TestMethod]
        public void DeserializeModel_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\model.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Model));
        }

        [TestMethod]
        public void DeserializeCompany_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\company.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Company));
        }

        [TestMethod]
        public void DeserializeLocation_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\location.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Location));
        }

        [TestMethod]
        public void DeserializeAccessory_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\accessory.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Accessory));
        }

        [TestMethod]
        public void DeserializeConsumable_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\consumable.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Consumable));
        }

        [TestMethod]
        public void DeserializeComponent_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\component.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Component));
        }

        [TestMethod]
        public void DeserializeUser_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\user.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(User));
        }

        [TestMethod]
        public void DeserializeStatusLabel_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\statuslabel.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(StatusLabel));
        }

        [TestMethod]
        public void DeserializeStatusLicense_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\license.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(License));
        }

        [TestMethod]
        public void DeserializeStatusCategory_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\category.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Category));
        }

        [TestMethod]
        public void DeserializeStatusManufacturer_ValidObject_ReturnAsset()
        {
            string obj = File.ReadAllText(@"..\..\TestObjs\manufacturer.json");
            ICommonEndpointModel result = JsonConvert.DeserializeObject<ICommonEndpointModel>(obj, new DetectJsonObjectType());
            Assert.IsInstanceOfType(result, typeof(Manufacturer));
        }
    }
}
