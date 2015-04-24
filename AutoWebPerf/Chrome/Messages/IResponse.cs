using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    interface IResponse
    {
    }

    interface IResponse<T> : IResponse
    {
        T Result { get; }
    }
}
