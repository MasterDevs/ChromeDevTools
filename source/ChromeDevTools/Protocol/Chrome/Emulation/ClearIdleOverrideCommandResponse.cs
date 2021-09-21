using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears Idle state overrides.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearIdleOverride)]
	[SupportedBy("Chrome")]
	public class ClearIdleOverrideCommandResponse
	{
	}
}
