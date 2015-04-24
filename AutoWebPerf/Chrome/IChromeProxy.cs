using AutoWebPerf.Chrome.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome
{
    interface IChromeProxy : IDisposable
    {
        Task Init();

        Task<IResponse> PublishAsync(IRequest request);

        void Subscribe<T>(ResponseHandler handler);
    }
}
