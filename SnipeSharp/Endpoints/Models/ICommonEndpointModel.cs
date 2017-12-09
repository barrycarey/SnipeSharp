using SnipeSharp.Common;
using System.Collections.Generic;

namespace SnipeSharp.Endpoints.Models
{
    // TODO: Check speed of using attributes for required headers vs a dict
    public interface ICommonEndpointModel
    {
        long Id { get; set; }
        string Name { get; set; }
        ResponseDate CreatedAt { get; set; }
        ResponseDate UpdatedAt { get; set; }
        Dictionary<string, string> BuildQueryString(); // 

    }
}
