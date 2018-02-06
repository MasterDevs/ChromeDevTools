using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("iOS")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
