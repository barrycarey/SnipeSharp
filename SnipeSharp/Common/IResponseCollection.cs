using SnipeSharp.Endpoints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public interface IResponseCollection
    {
        long Total { get; set; }
        List<ICommonEndpointModel> Rows { get; set; }
    }
}
