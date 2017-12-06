using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Sets or clears an override of the default background color of the frame. This override is used if the content does not specify one.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetDefaultBackgroundColorOverride)]
	[SupportedBy("Chrome")]
	public class SetDefaultBackgroundColorOverrideCommandResponse
	{
	}
}
