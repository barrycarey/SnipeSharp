using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    class RequiredValueIsNullException : Exception
    {
        public RequiredValueIsNullException()
        {
        }

        public RequiredValueIsNullException(string message) : base(message)
        {
        }

        public RequiredValueIsNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RequiredValueIsNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
