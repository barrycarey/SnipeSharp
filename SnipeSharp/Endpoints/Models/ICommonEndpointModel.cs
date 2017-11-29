using SnipeSharp.Common;

namespace SnipeSharp.Endpoints.Models
{
    // TODO: Check speed of using attributes for required headers vs a dict
    public interface ICommonEndpointModel
    {
        long Id { get; set; }
        string Name { get; set; }
        ResponseDate CreatedAt { get; set; }
        ResponseDate UpdatedAt { get; set; }

    }
}
