using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    class FailedToDetectObjectException : Exception
    {
        public FailedToDetectObjectException()
        {
        }

        public FailedToDetectObjectException(string message) : base(message)
        {
        }

        public FailedToDetectObjectException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FailedToDetectObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
