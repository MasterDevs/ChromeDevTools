using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[Command(ProtocolName.Worker.SendMessageToWorker)]
	[SupportedBy("Chrome")]
	public class SendMessageToWorkerCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
	}
}
