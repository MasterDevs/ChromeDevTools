using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.HighlightFrame)]
	[SupportedBy("Chrome")]
	public class HighlightFrameCommandResponse
	{
	}
}
