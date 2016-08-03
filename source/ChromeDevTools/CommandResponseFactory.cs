using MasterDevs.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;

namespace MasterDevs.ChromeDevTools
{
    public class CommandResponseFactory : ICommandResponseFactory
    {
        private readonly IMethodTypeMap _methodTypeMap;
        private readonly ICommandFactory _commandFactory;

        /// <summary>
        /// Used to deserialize command responses from JSON to .NET objects.
        /// </summary>
        private readonly JsonSerializer _serializer;

        public CommandResponseFactory(IMethodTypeMap methodTypeMap, ICommandFactory commandFactory)
            : this(methodTypeMap, commandFactory, new JsonSerializer() { ContractResolver = new MessageContractResolver() })
        {
        }

        public CommandResponseFactory(IMethodTypeMap methodTypeMap, ICommandFactory commandFactory, JsonSerializer serializer)
        {
            _methodTypeMap = methodTypeMap;
            _commandFactory = commandFactory;
            _serializer = serializer;
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
            if (null == methodString)
            {
                return null;
            }
            var typeInferredFromMethod = _methodTypeMap.GetCommandResponse(methodString);
            if (null == typeInferredFromMethod)
            {
                return null;
            }
            var genericEventType = typeof(CommandResponse<>);
            var commandResponseType = genericEventType.MakeGenericType(typeInferredFromMethod);
            var result = jObject.ToObject(commandResponseType, _serializer);
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