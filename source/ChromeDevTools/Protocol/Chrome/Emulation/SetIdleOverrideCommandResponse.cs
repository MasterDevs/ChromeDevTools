using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Idle state.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetIdleOverride)]
	[SupportedBy("Chrome")]
	public class SetIdleOverrideCommandResponse
	{
	}
}
