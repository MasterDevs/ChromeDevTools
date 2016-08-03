using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public static class ChromeSessionExtensions
    {
        public static Task<ICommandResponse> SendAsync<T>(this IChromeSession session, T parameter)
        {
            return session.SendAsync<T>(parameter, CancellationToken.None);
        }

        public static Task<ICommandResponse> SendAsync<T>(this IChromeSession session)
        {
            return session.SendAsync<T>(CancellationToken.None);
        }
    }
}
