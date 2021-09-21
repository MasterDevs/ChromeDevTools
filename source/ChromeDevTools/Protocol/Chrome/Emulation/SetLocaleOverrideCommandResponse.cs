using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides default host system locale with the specified one.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetLocaleOverride)]
	[SupportedBy("Chrome")]
	public class SetLocaleOverrideCommandResponse
	{
	}
}
