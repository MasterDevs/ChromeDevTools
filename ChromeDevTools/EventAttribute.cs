using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class EventAttribute : Attribute, IMethodNameAttribute
    {
        public EventAttribute(string methodName)
        {
            this.MethodName = methodName;
        }

        public string MethodName { get; private set; }
    }
}
