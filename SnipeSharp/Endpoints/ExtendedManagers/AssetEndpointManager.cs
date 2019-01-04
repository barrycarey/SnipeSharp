﻿using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.ExtendedManagers
{
    public class AssetEndpointManager<T> : EndPointManager<Asset>
    {
        // Explicitly pass hardware as the endpoint, ignoring what the client gives us
        public AssetEndpointManager(IRequestManager reqManager, string endPoint) : base(reqManager, "hardware")
        {
        }

        public IRequestResponse Checkout(ICommonEndpointModel item)
        {
            IRequestResponse result;
            string response = _reqManager.Post(string.Format("{0}/{1}/checkout", _endPoint, item.Id), item);
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

        public IRequestResponse Checkin(ICommonEndpointModel item)
        {
            IRequestResponse result;
            string response = _reqManager.Post(string.Format("{0}/{1}/checkin",_endPoint, item.Id), item);
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

        public Asset GetByAssetTag(string assetTag)
        {
            var response = _reqManager.Get(string.Format("{0}/bytag/{1}", _endPoint, assetTag));
            var result = JsonConvert.DeserializeObject<Asset>(response);
            return result;
        }

        public Asset GetBySerialNumber(string serialNumber)
        {
            var response = _reqManager.Get(string.Format("{0}/byserial/{1}", _endPoint, serialNumber));
            var result = JsonConvert.DeserializeObject<Asset>(response);
            return result;
        }
    }
}
