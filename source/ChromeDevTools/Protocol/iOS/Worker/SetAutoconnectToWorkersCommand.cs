using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("iOS")]
	public class SetAutoconnectToWorkersCommand
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public bool Value { get; set; }
	}
}
