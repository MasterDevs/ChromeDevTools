using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Stop)]
	public class StopCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
	}
}
