using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Memory
{
	[CommandResponse(ProtocolName.Memory.GetDOMCounters)]
	public class GetDOMCountersCommandResponse
	{
		/// <summary>
		/// Gets or sets Documents
		/// </summary>
		public long Documents { get; set; }
		/// <summary>
		/// Gets or sets Nodes
		/// </summary>
		public long Nodes { get; set; }
		/// <summary>
		/// Gets or sets JsEventListeners
		/// </summary>
		public long JsEventListeners { get; set; }
	}
}
