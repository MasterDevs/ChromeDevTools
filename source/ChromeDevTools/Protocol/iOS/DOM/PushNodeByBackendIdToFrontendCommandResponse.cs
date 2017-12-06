using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its backend node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PushNodeByBackendIdToFrontend)]
	[SupportedBy("iOS")]
	public class PushNodeByBackendIdToFrontendCommandResponse
	{
		/// <summary>
		/// Gets or sets The pushed node's id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
