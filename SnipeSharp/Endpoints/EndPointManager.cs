using Newtonsoft.Json;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;
using SnipeSharp.JsonConverters;
using System.Linq;

namespace SnipeSharp.Endpoints
{
    public class EndPointManager<T> where T : CommonEndpointModel 
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
        public ResponseCollection<T> GetAll()
        {
            string response = _reqManager.Get(_endPoint);
            ResponseCollection<T> results = JsonConvert.DeserializeObject<ResponseCollection<T>>(response);
            return results;
        }


        /// <summary>
        /// Search for Assets that match filters defined in an ISearchFilter object. 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public ResponseCollection<T> FindAll(ISearchFilter filter)
        {
            string response = _reqManager.Get(_endPoint, filter);
            ResponseCollection<T> results = JsonConvert.DeserializeObject<ResponseCollection<T>>(response);
            return results;
        }

        /// <summary>
        /// Finds all objects that match the filter and returns the first
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T FindOne(ISearchFilter filter)
        {
            string response = _reqManager.Get(_endPoint, filter);
            ResponseCollection<T> result = JsonConvert.DeserializeObject<ResponseCollection<T>>(response);
            return (result.Rows != null) ? result.Rows[0] : default(T);
        }

        /// <summary>
        /// Attempts to get a given object by it's ID
        /// </summary>
        /// <param name="id">ID of the object to find</param>
        /// <returns></returns>
        public T Get(int id)
        {
            // TODO: Find better way to deal with objects that are not found
            T result;
            string response = _reqManager.Get(string.Format("{0}/{1}", _endPoint, id.ToString()));
            result = JsonConvert.DeserializeObject<T>(response); 
            return result;
        }

        /// <summary>
        /// Attempts to find a given object by it's name. 
        /// </summary>
        /// <param name="name">The name of the object we want to find</param>
        /// <returns></returns>
        /// 
        public T Get(string name)
        {
            T result;
            name = name.ToLower();
            ResponseCollection<T> everything = GetAll();

            result = everything.Rows.Where(i => i.Name.ToLower() == name).FirstOrDefault();

            return result;
        }

        /// <summary>
        /// Creates a new object from the provided CommonResponseObject
        /// </summary>
        /// <param name="toCreate"></param>
        /// <returns></returns>
        public IRequestResponse Create(ICommonEndpointModel toCreate)
        {
            IRequestResponse response;

            string res = _reqManager.Post(_endPoint, toCreate);
            response = JsonConvert.DeserializeObject<RequestResponse>(res);
            return response;
        }

        public IRequestResponse Update(ICommonEndpointModel toUpdate)
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

        public IRequestResponse Delete(ICommonEndpointModel toDelete)
        {
            return Delete((int)toDelete.Id);
        }

        

    }
}
