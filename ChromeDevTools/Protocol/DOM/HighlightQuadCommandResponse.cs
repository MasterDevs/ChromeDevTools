using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightQuad)]
	public class HighlightQuadCommandResponse
	{
	}
}
