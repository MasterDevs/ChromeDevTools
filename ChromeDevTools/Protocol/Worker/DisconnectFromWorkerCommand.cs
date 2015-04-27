using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Worker
{
	[Command(ProtocolName.Worker.DisconnectFromWorker)]
	public class DisconnectFromWorkerCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
	}
}
