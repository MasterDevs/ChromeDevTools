using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommandResponse
	{
	}
}
