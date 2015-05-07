using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MasterDevs.ChromeDevTools
{
    public class EventFactory : IEventFactory
    {
        private readonly IMethodTypeMap _methodTypeMap;

        public EventFactory(IMethodTypeMap methodTypeMap)
        {
            _methodTypeMap = methodTypeMap;
        }

        public IEvent Create(byte[] responseBytes)
        {
            throw new NotImplementedException();
        }

        public IEvent Create(string responseText)
        {
            var jObject = JObject.Parse(responseText);
            var methodString = jObject["method"].GetSafeString();
            if (null == methodString)
            {
                return null;
            }
            var typeInferredFromMethod = _methodTypeMap.GetEvent(methodString);
            if (null == typeInferredFromMethod)
            {
                return null;
            }
            var genericEventType = typeof(Event<>);
            var commandResponseType = genericEventType.MakeGenericType(typeInferredFromMethod);
            var result = jObject.ToObject(commandResponseType);
            return result as IEvent;
        }
    }
}
