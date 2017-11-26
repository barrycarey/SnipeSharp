using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    // TODO: Check speed of using attributes for required headers vs a dict
    public interface ICommonEndpointObject
    {
        long Id { get; set; }
        string Name { get; set; }
        ResponseDate CreatedAt { get; set; }
        ResponseDate UpdatedAt { get; set; }

    }
}
