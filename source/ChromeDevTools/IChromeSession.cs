using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSession
    {
        Task<ICommandResponse> SendAsync<T>(T parameter, CancellationToken cancellationToken);

        Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken);

        void Subscribe<T>(Action<T> handler) where T : class;
    }
}