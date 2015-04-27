using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public class ChromeProcess : IChromeProcess
    {
        public DirectoryInfo UserDirectory { get; set; }
        public Process Process { get; set; }
        public string RemoteDebuggingUri { get; set; }
         

        public void Dispose()
        {
            Process.Kill();
            try
            {
                UserDirectory.Delete(true);
            }
            catch
            {
                Thread.Sleep(500);          // i'm being lazy because i'm tired
                UserDirectory.Delete(true);
            }
        }

        public async Task<string[]> GetSessions()
        {
            var remoteSessionUrls = new List<string>();
            var webClient = new WebClient();
            var uriBuilder = new UriBuilder(RemoteDebuggingUri);
            uriBuilder.Path = "/json";
            var remoteSessions = await webClient.DownloadStringTaskAsync(uriBuilder.Uri);
            using(var stringReader = new StringReader(remoteSessions))
            using(var jsonReader = new JsonTextReader(stringReader))
            {
                var sessionsObject = JToken.ReadFrom(jsonReader) as JArray;
                foreach(var sessionObject in sessionsObject)
                {
                    var sessionUrl = sessionObject["webSocketDebuggerUrl"].GetSafeString();
                    if(!String.IsNullOrEmpty(sessionUrl))
                    {
                        remoteSessionUrls.Add(sessionUrl);
                    }
                }
            }
            return remoteSessionUrls.ToArray();
        }
    }
}
