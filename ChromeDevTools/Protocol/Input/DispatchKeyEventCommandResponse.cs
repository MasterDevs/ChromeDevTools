using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Dispatches a key event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchKeyEvent)]
	public class DispatchKeyEventCommandResponse
	{
	}
}
