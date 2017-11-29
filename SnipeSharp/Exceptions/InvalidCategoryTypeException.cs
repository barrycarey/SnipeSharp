using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    class InvalidCategoryTypeException : Exception
    {
        public InvalidCategoryTypeException()
        {
        }

        public InvalidCategoryTypeException(string message) : base(message)
        {
        }

        public InvalidCategoryTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidCategoryTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
