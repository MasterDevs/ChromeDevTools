using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
