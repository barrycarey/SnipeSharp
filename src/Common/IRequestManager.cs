using SnipeSharp.Endpoints.SearchFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public interface IRequestManager
    {
        // TODO: Implement bad return status handeling in implementations of this
        ApiSettings _apiSettings { get; set; }
        string Put(string path, ICommonEndpointObject item);
        string Get(string path);
        string Get(string path, ISearchFilter filter);
        string Post(string path, ICommonEndpointObject item);
        string Delete(string path);
        string Checkin(string path); // TODO: Remove this once we cleanup checkin/checkout
        void CheckApiTokenAndUrl();
        string BuildBody();
    }
}
