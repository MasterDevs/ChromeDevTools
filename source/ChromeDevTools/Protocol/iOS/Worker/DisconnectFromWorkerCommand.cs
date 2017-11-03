using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.DisconnectFromWorker)]
	[SupportedBy("iOS")]
	public class DisconnectFromWorkerCommand: ICommand<DisconnectFromWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
