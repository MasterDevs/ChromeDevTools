using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerRegistrationUpdated)]
	[SupportedBy("Chrome")]
	public class WorkerRegistrationUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Registrations
		/// </summary>
		public ServiceWorkerRegistration[] Registrations { get; set; }
	}
}
