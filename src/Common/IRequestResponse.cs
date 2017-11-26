using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Common
{
    public interface IRequestResponse
    {
        Dictionary<string, string> Messages { get; set; }
        ICommonEndpointObject Payload { get; set; }
        string Status { get; set; }
    }
}
