using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MasterDevs.ChromeDevTools
{
    public class MethodTypeMap : IMethodTypeMap
    {
        private readonly Dictionary<string, Type> _commandTypes = new Dictionary<string, Type>();
        private readonly Dictionary<string, Type> _commandResponseTypes = new Dictionary<string, Type>();
        private readonly Dictionary<string, Type> _eventTypes = new Dictionary<string, Type>();

        public MethodTypeMap()
            : this("Chrome")
        {
        }

        public MethodTypeMap(string alias)
        {
            LoadMethodTypeMap(alias);
        }

        private void LoadMethodTypeMap(string alias)
        {
            var assembly = typeof(MethodTypeMap).GetTypeInfo().Assembly;
            var assemblyTypes = assembly.GetTypes();
            foreach (var type in assemblyTypes)
            {
                if (!type.GetTypeInfo().IsClass) continue;

                if (!type.Namespace.StartsWith($"MasterDevs.ChromeDevTools.Protocol.{alias}")) continue;

                if (type.Name.EndsWith("CommandResponse"))
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
            var attribute = type.GetTypeInfo().GetCustomAttributes(typeof(T))
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