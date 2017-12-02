using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;

namespace SnipeSharp.Endpoints
{
    // TODO: Not using currently.  Needs to figure out how to use with generics
    public interface IEndpointManager<T>
    {
        IResponseCollection<T> GetAll();
        IResponseCollection<T> FindAll(ISearchFilter filter);
        ICommonEndpointModel FindOne(ISearchFilter filter);
        ICommonEndpointModel Get(int id);
        ICommonEndpointModel Get(string name);
        IRequestResponse Create(ICommonEndpointModel toCreate);
        IRequestResponse Update(ICommonEndpointModel toUpdate);
        IRequestResponse Delete(int id);
    }
}
