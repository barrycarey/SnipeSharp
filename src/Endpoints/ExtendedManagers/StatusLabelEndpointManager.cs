using Newtonsoft.Json;
using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class StatusLabelEndpointManager : EndPointManager
    {
        public StatusLabelEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "statuslabels")
        {
        }

        public IResponseCollection GetAssignedAssets(ICommonEndpointObject statusLabel)
        {
            string response = _reqManager.Get(string.Format("{0}/{1}/assetlist", _endPoint, statusLabel.Id));
            IResponseCollection results = JsonConvert.DeserializeObject<ResultsRow>(response);
            return results;
        }
    }
}
