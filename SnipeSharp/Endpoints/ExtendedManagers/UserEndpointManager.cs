using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class UserEndpointManager : EndPointManager<User>
    {
        public UserEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "users")
        {
        }

        public ResponseCollection<User> GetAssignedAssets(ICommonEndpointModel user)
        {
            string response = _reqManager.Get(string.Format("{0}/{1}/assets", _endPoint, user.Id));
            ResponseCollection<User> results = JsonConvert.DeserializeObject<ResponseCollection<User>>(response);
            return results;
        }
    }
}
