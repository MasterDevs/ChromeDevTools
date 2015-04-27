using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StartWorker)]
	public class StartWorkerCommand
	{
		/// <summary>
		/// Gets or sets ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
