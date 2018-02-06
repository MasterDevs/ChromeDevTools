using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommandResponse
	{
	}
}
