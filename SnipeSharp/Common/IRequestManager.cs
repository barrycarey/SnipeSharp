using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;

namespace SnipeSharp.Common
{
    public interface IRequestManager
    {
        // TODO: Implement bad return status handeling in implementations of this
        ApiSettings _apiSettings { get; set; }
        string Put(string path, ICommonEndpointModel item);
        string Get(string path);
        string Get(string path, ISearchFilter filter);
        string Post(string path, ICommonEndpointModel item);
        string Delete(string path);
        string Checkin(string path); // TODO: Remove this once we cleanup checkin/checkout
        void CheckApiTokenAndUrl();
    }
}
