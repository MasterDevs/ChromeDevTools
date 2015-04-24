using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    class Response : IResponse
    {
    }
    class Response<T> : IResponse<T>
    {
        public T Result
        {
            get;
            set;
        }
    }

}
