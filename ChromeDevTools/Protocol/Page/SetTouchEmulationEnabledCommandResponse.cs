using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetTouchEmulationEnabled)]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
