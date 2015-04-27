using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	public class HideHighlightCommandResponse
	{
	}
}
