using SnipeSharp.Common;
using SnipeSharp.Endpoints;
using SnipeSharp.Endpoints.ExtendedManagers;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp
{
    public class SnipeItApi
    {
        public ApiSettings ApiSettings { get; set; }
        public AssetEndpointManager<Asset> AssetManager;
        public EndPointManager<Company> CompanyManager;
        public EndPointManager<Location> LocationManager;
        public EndPointManager<Accessory> AccessoryManager;
        public EndPointManager<Consumable> ConsumableManager;
        public EndPointManager<Component> ComponentManager;
        public UserEndpointManager UserManager;
        public EndPointManager<StatusLabel> StatusLabelManager;
        public EndPointManager<Model> ModelManager;
        public EndPointManager<License> LicenseManager;
        public EndPointManager<Category> CategoryManager;
        public EndPointManager<Manufacturer> ManufacturerManager;
        public EndPointManager<FieldSet> FieldSetManager;
        public StatusLabelEndpointManager<StatusLabel> StatusLabelsManager;
        public EndPointManager<Supplier> SupplierManager;
        public EndPointManager<Depreciation> DepreciationManager;
        public EndPointManager<Department> DepartmentManager;
        // Test 
        public IRequestManager ReqManager;

        public SnipeItApi()
        {            
            ApiSettings = new ApiSettings();
            ReqManager = new RequestManagerRestSharp(ApiSettings);
            AssetManager = new AssetEndpointManager<Asset>(ReqManager, "hardware");
            CompanyManager = new EndPointManager<Company>(ReqManager, "companies");
            LocationManager = new EndPointManager<Location>(ReqManager, "locations");
            AccessoryManager = new EndPointManager<Accessory>(ReqManager, "accessories");
            ConsumableManager = new EndPointManager<Consumable>(ReqManager, "consumables");
            ComponentManager = new EndPointManager<Component>(ReqManager, "components");
            UserManager = new UserEndpointManager(ReqManager, "users");
            StatusLabelManager = new StatusLabelEndpointManager<StatusLabel>(ReqManager, "statuslabels");
            ModelManager = new EndPointManager<Model>(ReqManager, "models");
            LicenseManager = new EndPointManager<License>(ReqManager, "licenses");
            CategoryManager = new EndPointManager<Category>(ReqManager, "categories");
            ManufacturerManager = new EndPointManager<Manufacturer>(ReqManager, "manufacturers");        
            FieldSetManager = new EndPointManager<FieldSet>(ReqManager, "fieldsets");
            SupplierManager = new EndPointManager<Supplier>(ReqManager, "suppliers");
            DepreciationManager = new EndPointManager<Depreciation>(ReqManager, "depreciations");
            DepartmentManager = new EndPointManager<Department>(ReqManager, "departments");


        }

    }
}
