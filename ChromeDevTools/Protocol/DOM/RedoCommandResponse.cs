using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Redo)]
	public class RedoCommandResponse
	{
	}
}
