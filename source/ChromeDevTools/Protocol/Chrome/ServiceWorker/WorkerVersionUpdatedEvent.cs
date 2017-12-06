using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerVersionUpdated)]
	[SupportedBy("Chrome")]
	public class WorkerVersionUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Versions
		/// </summary>
		public ServiceWorkerVersion[] Versions { get; set; }
	}
}
