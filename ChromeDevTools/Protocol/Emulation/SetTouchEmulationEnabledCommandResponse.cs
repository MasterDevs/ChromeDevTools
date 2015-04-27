using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
