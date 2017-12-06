using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightFrame)]
	[SupportedBy("iOS")]
	public class HighlightFrameCommandResponse
	{
	}
}
