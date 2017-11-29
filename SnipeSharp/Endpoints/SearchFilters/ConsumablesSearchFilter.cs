using SnipeSharp.Attributes;
using SnipeSharp.Endpoints.SearchFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Endpoints.SearchFilters
{
    class ConsumablesSearchFilter : SearchFilter
    {
        [FilterParamName("order_number")]
        public string OrderNumber { get; set; }

        public bool Expand { get; set; }
    }
}
