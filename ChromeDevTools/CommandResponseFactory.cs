using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeDevTools
{
    public class CommandResponseFactory : ICommandResponseFactory
    {
        private readonly IMethodTypeMap _methodTypeMap;
        private readonly ICommandFactory _commandFactory;

        public CommandResponseFactory(IMethodTypeMap methodTypeMap, ICommandFactory commandFactory)
        {
            _methodTypeMap = methodTypeMap;
            _commandFactory = commandFactory;
        }

        public ICommandResponse Create(byte[] responseBytes)
        {
            throw new NotImplementedException();
        }

        public ICommandResponse Create(string responseText)
        {
            var jObject = JObject.Parse(responseText);
            if (null != jObject["error"])
            {
                return jObject.ToObject<ErrorResponse>();
            }
            var methodString = GetMethod(jObject);
            if(null == methodString)
            {
                return null;
            }
            var typeInferredFromMethod = _methodTypeMap.GetCommandResponse(methodString);
            if(null == typeInferredFromMethod)
            {
                return null;
            }
            var genericEventType = typeof(CommandResponse<>);
            var commandResponseType = genericEventType.MakeGenericType(typeInferredFromMethod);
            var result = jObject.ToObject(commandResponseType);
            return result as ICommandResponse;
        }

        private string GetMethod(JObject jObject)
        {
            var methodString = jObject["method"].GetSafeString();
            if (null == methodString)
            {
                var commandIdString = jObject["id"].GetSafeString();
                long commandId;
                if (long.TryParse(commandIdString, out commandId))
                {
                    methodString = _commandFactory.GetMethod(commandId);
                }
            }
            return methodString;
        }
    }
}
