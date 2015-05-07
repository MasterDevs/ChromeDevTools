using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
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
