using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Requests that group of <code>BackendNodeIds</code> is released.
	/// </summary>
	[Command(ProtocolName.DOM.ReleaseBackendNodeIds)]
	[SupportedBy("iOS")]
	public class ReleaseBackendNodeIdsCommand: ICommand<ReleaseBackendNodeIdsCommandResponse>
	{
		/// <summary>
		/// Gets or sets The backend node ids group name.
		/// </summary>
		public string NodeGroup { get; set; }
	}
}
