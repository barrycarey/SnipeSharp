using System;
using System.Runtime.Serialization;

namespace SnipeSharp.Exceptions
{
    class InvalidStatusLabelTypeException : Exception
    {
        public InvalidStatusLabelTypeException()
        {
        }

        public InvalidStatusLabelTypeException(string message) : base(message)
        {
        }

        public InvalidStatusLabelTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidStatusLabelTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
