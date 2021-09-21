using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DispatchPeriodicSyncEvent)]
	[SupportedBy("Chrome")]
	public class DispatchPeriodicSyncEventCommand: ICommand<DispatchPeriodicSyncEventCommandResponse>
	{
		/// <summary>
		/// Gets or sets Origin
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets Tag
		/// </summary>
		public string Tag { get; set; }
	}
}
