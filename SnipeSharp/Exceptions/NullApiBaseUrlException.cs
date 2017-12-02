using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    public class NullApiBaseUrlException : Exception
    {
        public NullApiBaseUrlException()
        {
        }

        public NullApiBaseUrlException(string message) : base(message)
        {
        }

        public NullApiBaseUrlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullApiBaseUrlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
