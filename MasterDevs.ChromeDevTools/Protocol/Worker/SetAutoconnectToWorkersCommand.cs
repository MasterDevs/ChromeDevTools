using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Command(ProtocolName.Worker.SetAutoconnectToWorkers)]
	public class SetAutoconnectToWorkersCommand
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public bool Value { get; set; }
	}
}
