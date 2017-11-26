using SnipeSharp.Common;
using SnipeSharp.Endpoints.ExtendedManagers;

namespace SnipeSharp
{
    public class SnipeItApi
    {
        public ApiSettings ApiSettings { get; set; }
        public AssetEndpointManager AssetManager;
        public EndPointManager CompanyManager;
        public EndPointManager LocationManager;
        public EndPointManager AccessoryManager;
        public EndPointManager ConsumableManager;
        public EndPointManager ComponentManager;
        public UserEndpointManager UserManager;
        public EndPointManager StatusLabelManager;
        public EndPointManager ModelManager;
        public EndPointManager LicenseManager;
        public EndPointManager CategoryManager;
        public EndPointManager ManufacturerManager;
        public EndPointManager FieldSetManager;
        public StatusLabelEndpointManager StatusLabelsManager;
        public EndPointManager SupplierManager;
        public EndPointManager DepreciationManager;
        public EndPointManager DepartmentManager;

        public IRequestManager ReqManager;

        public SnipeItApi()
        {            
            ApiSettings = new ApiSettings();
            ReqManager = new RequestManager(ApiSettings);
            AssetManager = new AssetEndpointManager(ReqManager, "hardware");
            CompanyManager = new EndPointManager(ReqManager, "companies");
            LocationManager = new EndPointManager(ReqManager, "locations");
            AccessoryManager = new EndPointManager(ReqManager, "accessories");
            ConsumableManager = new EndPointManager(ReqManager, "consumables");
            ComponentManager = new EndPointManager(ReqManager, "components");
            UserManager = new UserEndpointManager(ReqManager, "users");
            StatusLabelManager = new StatusLabelEndpointManager(ReqManager, "statuslabels");
            ModelManager = new EndPointManager(ReqManager, "models");
            LicenseManager = new EndPointManager(ReqManager, "licenses");
            CategoryManager = new EndPointManager(ReqManager, "categories");
            ManufacturerManager = new EndPointManager(ReqManager, "manufacturers");        
            FieldSetManager = new EndPointManager(ReqManager, "fieldsets");
            SupplierManager = new EndPointManager(ReqManager, "suppliers");
            DepreciationManager = new EndPointManager(ReqManager, "depreciations");
            DepartmentManager = new EndPointManager(ReqManager, "departments");


        }

    }
}
