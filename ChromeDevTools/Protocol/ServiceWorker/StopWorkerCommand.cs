using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopWorker)]
	public class StopWorkerCommand
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
