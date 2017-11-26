using SnipeSharp.Attributes;

namespace SnipeSharp.Endpoints.SearchFilters
{
    class AccessoriesSearchFilter : SearchFilter
    {
        [FilterParamName("order_number")]
        public string OrderNumber { get; set; }

        public bool Expand { get; set; }
    }
}
