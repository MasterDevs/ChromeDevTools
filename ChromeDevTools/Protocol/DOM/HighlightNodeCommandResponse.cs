using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightNode)]
	public class HighlightNodeCommandResponse
	{
	}
}
