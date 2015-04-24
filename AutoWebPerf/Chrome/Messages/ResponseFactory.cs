using AutoWebPerf.Chrome.Messages.Network;
using AutoWebPerf.Chrome.Messages.Page;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    class ResponseFactory : IResponseFactory
    {
        private readonly static Lazy<Dictionary<string, Type>> _methodTypeMapLazy = new Lazy<Dictionary<string, Type>>(LoadMethodTypeMap);

        private static Dictionary<string, Type> LoadMethodTypeMap()
        {
            var iresponseType = typeof(IResponse);
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyTypes = assembly.GetTypes();
            var responseTypes = assemblyTypes.Where(t => iresponseType.IsAssignableFrom(t) && t.IsClass);
            Dictionary<string, Type> result = new Dictionary<string, Type>();
            foreach(var responseType in responseTypes)
            {
                var methodNameAttribute = responseType.GetCustomAttribute<MethodNameAttribute>(false) as MethodNameAttribute;
                if (null == methodNameAttribute) continue;
                result[methodNameAttribute.MethodName] = responseType;
            }
            return result;
        }

        private readonly IRequestFactory _requestFactory;

        public ResponseFactory(IRequestFactory requestFactory)
        {
            _requestFactory = requestFactory;
        }

        public IResponse Create(string responseText)
        {
            var jObject = JObject.Parse(responseText);
            if(null != jObject["error"])
            {
                return jObject.ToObject<ErrorResponse>();
            }
            var response = ResponseFromMethodResponse(jObject);
            if (null != response) return response;
            response = ResponseFromMethodLookupResponse(jObject);
            if (null != response) return response;
            throw new Exception("We could not create a response from text: [" + responseText + "]");
        }

        private IResponse ResponseFromMethodLookupResponse(JObject jObject)
        {
            var resultObj = jObject["result"];
            if (null == resultObj) return null;
            var resultIdObj = jObject["id"];
            if (null == resultIdObj) return null;
            long resultId;
            if (!long.TryParse(resultIdObj.ToString(), out resultId)) return null;
            var methodLookupResult = _requestFactory.GetMethod(resultId);
            if(String.IsNullOrEmpty(methodLookupResult)) return null;
            return ResponseFromMethodResponse(methodLookupResult, jObject);
        }

        private IResponse ResponseFromMethodResponse(JObject jObject)
        {
            var method = jObject["method"];
            if (null == method) return null;
            return ResponseFromMethodResponse(method.ToString(), jObject);
        }

        private IResponse ResponseFromMethodResponse(string methodName, JObject jObject)
        {
            if(String.IsNullOrEmpty(methodName)) return null;
            Type responseType = null;
            if (!_methodTypeMapLazy.Value.TryGetValue(methodName, out responseType))
            {
                throw new ArgumentException("We could not find a response type for the method " + methodName);
            }
            var response = jObject.ToObject(responseType) as IResponse;
            return response;
        }


        public IResponse Create(byte[] responseBytes)
        {
            var responseString = Encoding.Default.GetString(responseBytes);
            return Create(responseString);
        }
    }
}
