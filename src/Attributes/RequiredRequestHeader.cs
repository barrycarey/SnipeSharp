using System;

namespace SnipeSharp.Attributes
{
    /// <summary>
    /// Since the SnipeIT Api uses inconsistent names between returned data and the headers needed on create we can use this attribute
    /// to pass in the header name we need when creating something
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredRequestHeader : Attribute
    {
        private string _headerName;
        public string HeaderName { get { return _headerName; } }

        public RequiredRequestHeader(string headerName)
        {
            _headerName = headerName;
        }
    }
}
