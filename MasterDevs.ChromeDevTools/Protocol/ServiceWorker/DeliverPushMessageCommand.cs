using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DeliverPushMessage)]
	public class DeliverPushMessageCommand
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
		/// Gets or sets Data
		/// </summary>
		public string Data { get; set; }
	}
}
