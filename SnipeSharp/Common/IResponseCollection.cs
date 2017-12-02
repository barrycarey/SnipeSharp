using System.Collections.Generic;

namespace SnipeSharp.Common
{
    public interface IResponseCollection<T>
    {
        long Total { get; set; }
        List<T> Rows { get; set; }
    }
}
