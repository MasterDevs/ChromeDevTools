using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    interface IRequest
    {
        long Id { get; }

        string Method { get; }
    }

    interface IRequest<T> : IRequest
    {
        T Params { get; }
    }
}
