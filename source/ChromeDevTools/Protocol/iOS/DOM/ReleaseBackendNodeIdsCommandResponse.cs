using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Requests that group of <code>BackendNodeIds</code> is released.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ReleaseBackendNodeIds)]
	[SupportedBy("iOS")]
	public class ReleaseBackendNodeIdsCommandResponse
	{
	}
}
