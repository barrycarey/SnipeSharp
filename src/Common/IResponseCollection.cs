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
        List<ICommonEndpointObject> Rows { get; set; }
    }
}
