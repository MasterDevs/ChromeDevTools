using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that a batch of nodes is sent to the caller given their backend node ids.
	/// </summary>
	[Command(ProtocolName.DOM.PushNodesByBackendIdsToFrontend)]
	[SupportedBy("Chrome")]
	public class PushNodesByBackendIdsToFrontendCommand: ICommand<PushNodesByBackendIdsToFrontendCommandResponse>
	{
		/// <summary>
		/// Gets or sets The array of backend node ids.
		/// </summary>
		public long[] BackendNodeIds { get; set; }
	}
}
