using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class StatusLabelEndpointManager<T> : EndPointManager<StatusLabel>
    {
        public StatusLabelEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "statuslabels")
        {
        }

        public ResponseCollection<StatusLabel> GetAssignedAssets(ICommonEndpointModel statusLabel)
        {
            string response = _reqManager.Get(string.Format("{0}/{1}/assetlist", _endPoint, statusLabel.Id));
            ResponseCollection<StatusLabel> results = JsonConvert.DeserializeObject<ResponseCollection<StatusLabel>>(response);
            return results;
        }
    }
}
