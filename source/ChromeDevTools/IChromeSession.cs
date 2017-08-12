using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface ICommand<T>
    {

    }
    public interface IChromeSession
    {
        Task<CommandResponse<TResponse>> SendAsync<TResponse>(ICommand<TResponse> parameter, CancellationToken cancellationToken);

        Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken);

        void Subscribe<T>(Action<T> handler) where T : class;
    }
}