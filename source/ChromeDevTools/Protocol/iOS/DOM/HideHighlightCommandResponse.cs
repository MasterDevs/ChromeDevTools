using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("iOS")]
	public class HideHighlightCommandResponse
	{
	}
}
