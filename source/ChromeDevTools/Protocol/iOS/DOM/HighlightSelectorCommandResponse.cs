using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Highlights all DOM nodes that match a given selector. A string containing a CSS selector must be specified.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightSelector)]
	[SupportedBy("iOS")]
	public class HighlightSelectorCommandResponse
	{
	}
}
