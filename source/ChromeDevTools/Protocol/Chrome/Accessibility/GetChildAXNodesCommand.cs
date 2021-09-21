using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a particular accessibility node by AXNodeId.
	/// Requires `enable()` to have been called previously.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetChildAXNodes)]
	[SupportedBy("Chrome")]
	public class GetChildAXNodesCommand: ICommand<GetChildAXNodesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets The frame in whose document the node resides.
		/// If omitted, the root frame is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
