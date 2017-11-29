using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.SearchFilters;

namespace SnipeSharp.Endpoints.SearchFilters
{
    class ComponentsSearchFilter : SearchFilter
    {
        [FilterParamName("order_number")]
        public string OrderNumber { get; set; }

        public bool Expand { get; set; }
    }
}
