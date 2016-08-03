using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.DisconnectFromWorker)]
	[SupportedBy("iOS")]
	public class DisconnectFromWorkerCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
