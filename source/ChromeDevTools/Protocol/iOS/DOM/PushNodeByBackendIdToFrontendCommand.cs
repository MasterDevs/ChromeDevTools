using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its backend node id.
	/// </summary>
	[Command(ProtocolName.DOM.PushNodeByBackendIdToFrontend)]
	[SupportedBy("iOS")]
	public class PushNodeByBackendIdToFrontendCommand: ICommand<PushNodeByBackendIdToFrontendCommandResponse>
	{
		/// <summary>
		/// Gets or sets The backend node id of the node.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
