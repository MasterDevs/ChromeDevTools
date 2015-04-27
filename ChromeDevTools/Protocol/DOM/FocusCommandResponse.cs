using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Focus)]
	public class FocusCommandResponse
	{
	}
}
