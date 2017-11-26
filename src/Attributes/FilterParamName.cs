using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeSharp.Attributes
{
    /// <summary>
    /// Used to tag class properties with the name we should use in the URL query
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class FilterParamName : Attribute
    {
        private string _paramName;
        public string ParamName { get { return _paramName; } }

        public FilterParamName(string paramName)
        {
            _paramName = paramName;
        }
    }
}


