using System;

namespace AutoWebPerf.Chrome.Messages
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string methodName)
        {
            this.MethodName = methodName;
        }

        public string MethodName { get; private set; }
    }
}