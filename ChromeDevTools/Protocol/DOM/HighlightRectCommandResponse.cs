using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightRect)]
	public class HighlightRectCommandResponse
	{
	}
}
