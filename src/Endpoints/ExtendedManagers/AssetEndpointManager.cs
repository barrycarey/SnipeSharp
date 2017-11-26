using Newtonsoft.Json;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class AssetEndpointManager : EndPointManager
    {
        // Explicitly pass hardware as the endpoint, ignoring what the client gives us
        public AssetEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "hardware")
        {
        }

        public IRequestResponse Checkout(ICommonEndpointObject item)
        {
            IRequestResponse result;
            string response = _reqManager.Post(string.Format("{0}/{1}/checkout", _endPoint, item.Id), item);
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

        public IRequestResponse Checkin(ICommonEndpointObject item)
        {
            IRequestResponse result;
            string response = _reqManager.Checkin(string.Format("{0}/{1}/checkin",_endPoint, item.Id));
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

    }
}
