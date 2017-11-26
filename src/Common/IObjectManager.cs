using SnipeSharp.Endpoints.SearchFilters;

namespace SnipeSharp.Common
{
    public interface IObjectManager
    {
        IResponseCollection GetAll();
        IResponseCollection FindAll(ISearchFilter filter);
        ICommonEndpointObject Get(int id);
        ICommonEndpointObject Get(string name);
        IRequestResponse Create(ICommonEndpointObject toCreate);
    }
}
