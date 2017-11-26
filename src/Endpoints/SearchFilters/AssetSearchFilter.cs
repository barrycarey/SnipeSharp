using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.Models;

namespace SnipeSharp.Endpoints.SearchFilters
{
    public class AssetSearchFilter : SearchFilter
    {
        [FilterParamName("order_number")]
        public string OrderNumber { get; set; }

        [FilterParamName("model_id")]
        public int? ModelId { get; set; }

        [FilterParamName("category_id")]
        public int? CategoryId { get; set; }

        [FilterParamName("manufacturer_id")]
        public Manufacturer Manufacturer { get; set; }

        [FilterParamName("company_id")]
        public int? CompanyId { get; set; }

        [FilterParamName("location_id")]
        public Location Location { get; set; }

        public string Status { get; set; }

        [FilterParamName("status_id")]
        public int? StatusId { get; set; }

    }
}
