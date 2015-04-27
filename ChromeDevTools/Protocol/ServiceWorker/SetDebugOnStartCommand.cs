using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SetDebugOnStart)]
	public class SetDebugOnStartCommand
	{
		/// <summary>
		/// Gets or sets DebugOnStart
		/// </summary>
		public bool DebugOnStart { get; set; }
	}
}
