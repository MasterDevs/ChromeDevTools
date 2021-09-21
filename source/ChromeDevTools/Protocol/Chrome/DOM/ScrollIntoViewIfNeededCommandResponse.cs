using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Scrolls the specified rect of the given node into view if not already visible.
	/// Note: exactly one between nodeId, backendNodeId and objectId should be passed
	/// to identify the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ScrollIntoViewIfNeeded)]
	[SupportedBy("Chrome")]
	public class ScrollIntoViewIfNeededCommandResponse
	{
	}
}
