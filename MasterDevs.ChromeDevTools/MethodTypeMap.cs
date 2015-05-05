using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public class MethodTypeMap : IMethodTypeMap
    {
        private readonly Dictionary<string, Type> _commandTypes = new Dictionary<string, Type>();
        private readonly Dictionary<string, Type> _commandResponseTypes = new Dictionary<string, Type>();
        private readonly Dictionary<string, Type> _eventTypes = new Dictionary<string, Type>();

        public MethodTypeMap()
        {
            LoadMethodTypeMap();
        }
        private void LoadMethodTypeMap()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyTypes = assembly.GetTypes();
            foreach(var type in assemblyTypes)
            {
                if(!type.IsClass) continue;
                if(type.Name.EndsWith("CommandResponse"))
                {
                    var methodName = GetMethodName<CommandResponseAttribute>(type);
                    if (null == methodName) continue;
                    _commandResponseTypes[methodName] = type;
                }
                if (type.Name.EndsWith("Command"))
                {
                    var methodName = GetMethodName<CommandAttribute>(type);
                    if (null == methodName) continue;
                    _commandTypes[methodName] = type;
                }
                if (type.Name.EndsWith("Event"))
                {
                    var methodName = GetMethodName<EventAttribute>(type);
                    if (null == methodName) continue;
                    _eventTypes[methodName] = type;
                }
            }
        }

        private string GetMethodName<T>(Type type) where T : IMethodNameAttribute
        {
            var attribute = type.GetCustomAttributes(typeof(T))
                .FirstOrDefault();
            if (null == attribute) return null;
            var methodNameAttribute = attribute as IMethodNameAttribute;
            if (null == methodNameAttribute) return null;
            return methodNameAttribute.MethodName;
        }

        public Type GetCommand(string method)
        {
            Type type;
            _commandTypes.TryGetValue(method, out type);
            return type;
        }

        public Type GetCommandResponse(string method)
        {
            Type type;
            _commandResponseTypes.TryGetValue(method, out type);
            return type;
        }

        public Type GetEvent(string method)
        {
            Type type;
            _eventTypes.TryGetValue(method, out type);
            return type;
        }
    }
}
