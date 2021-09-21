using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables or disables simulating a focused and active page.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetFocusEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetFocusEmulationEnabledCommandResponse
	{
	}
}
