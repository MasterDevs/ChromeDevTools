using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools
{
    public class RemoteChromeProcess : IChromeProcess
    {
        public RemoteChromeProcess(Uri remoteDebuggingUri)
        {
            RemoteDebuggingUri = remoteDebuggingUri;
        }

        public Uri RemoteDebuggingUri { get; }

        public virtual void Dispose()
        {
        }

        public async Task<ChromeSessionInfo[]> GetSessions()
        {
            using (var http = new HttpClient
            {
                BaseAddress = RemoteDebuggingUri
            })
            {
                string json = await http.GetStringAsync("/json");
                return JsonConvert.DeserializeObject<ChromeSessionInfo[]>(json);
            }
        }

        
    }
}