using Newtonsoft.Json;
using SnipeSharp.Endpoints.SearchFilters;
using SnipeSharp.JsonConverters;
using System.Linq;

namespace SnipeSharp.Common
{
    public class EndPointManager : IObjectManager
    {
        protected IRequestManager _reqManager;
        protected string _endPoint;

        public EndPointManager(IRequestManager reqManager, string endPoint)
        {
            _reqManager = reqManager;
            _endPoint = endPoint;
        }

        /// <summary>
        /// Gets all objects from the endpoint
        /// </summary>
        /// <returns></returns>
        public IResponseCollection GetAll()
        {
            string response = _reqManager.Get(_endPoint);
            IResponseCollection results = JsonConvert.DeserializeObject<ResultsRow>(response);
            return results;
        }


        /// <summary>
        /// Search for Assets that match filters defined in an ISearchFilter object. 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        // TODO: This should probabe be named different since it returns a collection instead of a single item
        public IResponseCollection FindAll(ISearchFilter filter)
        {
            string response = _reqManager.Get(_endPoint, filter);
            IResponseCollection results = JsonConvert.DeserializeObject<ResultsRow>(response);
            return results;
        }

        /// <summary>
        /// Finds all objects that match the filter and returns the first
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public ICommonEndpointObject FindOne(ISearchFilter filter)
        {
            string response = _reqManager.Get(_endPoint, filter);
            IResponseCollection result = JsonConvert.DeserializeObject<ResultsRow>(response);
            return (result.Rows != null) ? result.Rows[0] : null;
        }

        /// <summary>
        /// Attempts to get a given object by it's ID
        /// </summary>
        /// <param name="id">ID of the object to find</param>
        /// <returns></returns>
        // TODO: See if we get a concrete object or Iface back from this
        public ICommonEndpointObject Get(int id)
        {
            // TODO: Find better way to deal with objects that are not found
            ICommonEndpointObject result;
            string response = _reqManager.Get(string.Format("{0}/{1}", _endPoint, id.ToString()));
            result = JsonConvert.DeserializeObject<ICommonEndpointObject>(response, new DetectJsonObjectType()); // TODO This feels like fuckery
            return result;
        }

        /// <summary>
        /// Attempts to find a given object by it's name. 
        /// </summary>
        /// <param name="name">The name of the object we want to find</param>
        /// <returns></returns>
        public ICommonEndpointObject Get(string name)
        {
            ICommonEndpointObject result;
            name = name.ToLower();
            IResponseCollection everything = GetAll();

            result = everything.Rows.Where(i => i.Name.ToLower() == name).FirstOrDefault();

            return result;
        }

        /// <summary>
        /// Creates a new object from the provided CommonResponseObject
        /// </summary>
        /// <param name="toCreate"></param>
        /// <returns></returns>
        public IRequestResponse Create(ICommonEndpointObject toCreate)
        {
            IRequestResponse response;

            string res = _reqManager.Post(_endPoint, toCreate);
            response = JsonConvert.DeserializeObject<RequestResponse>(res);
            return response;
        }

        public IRequestResponse Update(ICommonEndpointObject toUpdate)
        {
            IRequestResponse result;
            string response = _reqManager.Put(string.Format("{0}/{1}", _endPoint, toUpdate.Id), toUpdate);
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

        public IRequestResponse Delete(int id)
        {
            IRequestResponse result;
            string response = _reqManager.Delete(string.Format("{0}/{1}", _endPoint, id.ToString()));
            result = JsonConvert.DeserializeObject<RequestResponse>(response);
            return result;
        }

        // TODO: This is specific to assets.  We should probably extend this class and make one specific for assets. 

    }
}
