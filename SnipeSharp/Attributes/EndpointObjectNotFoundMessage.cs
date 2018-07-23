using System;

namespace SnipeSharp.Attributes
{
    /// <summary>
    /// Since the SnipeIT Api uses inconsistent error string to note whether or not an object exists or not, we can use this attribute to declare it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EndpointObjectNotFoundMessage : Attribute
    {
        public string Message { get; private set; }
        public EndpointObjectNotFoundMessage(string notFoundMessage)
        {
            Message = notFoundMessage;
        }
    }
}
