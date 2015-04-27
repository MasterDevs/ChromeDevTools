using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.InspectWorker)]
	public class InspectWorkerCommand
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
