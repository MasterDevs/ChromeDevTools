using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightFrame)]
	public class HighlightFrameCommandResponse
	{
	}
}
