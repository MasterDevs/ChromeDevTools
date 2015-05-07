using System;
using System.Linq;

namespace MasterDevs.ChromeDevTools
{
    public static class ObjectExtensions
    {
        public static string GetMethod(this object obj)
        {
            if (null == obj) return null;
            return GetMethod(obj.GetType());
        }

        public static string GetMethod(this Type type)
        {
            if (null == type) return null;
            var eventAttribute = type.GetCustomAttributes(typeof(EventAttribute), true)
                .FirstOrDefault() as EventAttribute;
            if (null != eventAttribute) return eventAttribute.MethodName;
            var commandAttribute = type.GetCustomAttributes(typeof(CommandAttribute), true)
                .FirstOrDefault() as CommandAttribute;
            if (null != commandAttribute) return commandAttribute.MethodName;
            var commandResponseAttribute = type.GetCustomAttributes(typeof(CommandResponseAttribute), true)
                .FirstOrDefault() as CommandResponseAttribute;
            if (null != commandResponseAttribute) return commandResponseAttribute.MethodName;

            // maybe it's generic parameter has a method
            if (type.IsGenericType)
            {
                return type.GenericTypeArguments
                    .FirstOrDefault()
                    .GetMethod();
            }

            throw new Exception("Could not determine the method type for " + type);
        }
    }
}