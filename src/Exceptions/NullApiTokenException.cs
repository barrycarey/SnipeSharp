using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    class NullApiTokenException : Exception
    {
        public NullApiTokenException()
        {
        }

        public NullApiTokenException(string message) : base(message)
        {
        }

        public NullApiTokenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullApiTokenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
