using System;

namespace MasterDevs.ChromeDevTools
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class CommandResponseAttribute : Attribute, IMethodNameAttribute
    {
        public CommandResponseAttribute(string methodName)
        {
            this.MethodName = methodName;
        }

        public string MethodName { get; private set; }
    }
}