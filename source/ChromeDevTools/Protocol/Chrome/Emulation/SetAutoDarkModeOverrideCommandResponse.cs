using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Automatically render all web contents using a dark theme.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetAutoDarkModeOverride)]
	[SupportedBy("Chrome")]
	public class SetAutoDarkModeOverrideCommandResponse
	{
	}
}
