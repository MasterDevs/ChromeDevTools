using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.HighlightQuad)]
	[SupportedBy("Chrome")]
	public class HighlightQuadCommandResponse
	{
	}
}
