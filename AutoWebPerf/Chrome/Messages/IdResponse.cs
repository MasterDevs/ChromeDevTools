using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    class IdResponse : Response
    {
        public string Id { get; set; }
    }

    class IdResponse<T> : IdResponse, IResponse<T>
    {
        public T Result
        {
            get;
            set;
        }
    }
}
