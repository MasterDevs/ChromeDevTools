using System;

namespace MasterDevs.ChromeDevTools
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ProtocolNameAttribute : Attribute
    {
        public ProtocolNameAttribute(string methodName)
        {
            this.MethodName = methodName;
        }

        public string MethodName { get; private set; }
    }
}