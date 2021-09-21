using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides default host system timezone with the specified one.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetTimezoneOverride)]
	[SupportedBy("Chrome")]
	public class SetTimezoneOverrideCommandResponse
	{
	}
}
