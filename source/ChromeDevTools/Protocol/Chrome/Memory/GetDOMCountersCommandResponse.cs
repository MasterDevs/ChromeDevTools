using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	[CommandResponse(ProtocolName.Memory.GetDOMCounters)]
	[SupportedBy("Chrome")]
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
