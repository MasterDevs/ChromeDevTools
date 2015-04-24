using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    public class Request : IRequest
    {
        public Request(long id)
        {
            Id = id;
            Method = LookupMethodAttribute();
        }

        private string LookupMethodAttribute()
        {
            var methodNameAttribute = this.GetType().GetCustomAttributes(typeof(MethodNameAttribute), true)
                .FirstOrDefault() as MethodNameAttribute;
            if(null == methodNameAttribute)
            {
                throw new Exception("Request(id) constructor is called on an object without a [MethodName] attribute");
            }
            return methodNameAttribute.MethodName;
        }

        public Request(long id, string method)
        {
            Id = id;
            Method = method;
        }

        public long Id
        {
            get;
            private set;
        }

        public string Method
        {
            get;
            private set;
        }
    }

    public class Request<T> : Request, IRequest<T>
    {
        public Request(long id, T methodParams)
            : base(id)
        {
            Params = methodParams;
        }
        
        public T Params
        {
            get;
            private set;
        }
    }

}
