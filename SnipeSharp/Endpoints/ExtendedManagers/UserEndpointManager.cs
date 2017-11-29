using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class UserEndpointManager : EndPointManager
    {
        public UserEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "users")
        {
        }

        public IResponseCollection GetAssignedAssets(ICommonEndpointModel user)
        {
            string response = _reqManager.Get(string.Format("{0}/{1}/assets", _endPoint, user.Id));
            IResponseCollection results = JsonConvert.DeserializeObject<ResultsRow>(response);
            return results;
        }
    }
}
