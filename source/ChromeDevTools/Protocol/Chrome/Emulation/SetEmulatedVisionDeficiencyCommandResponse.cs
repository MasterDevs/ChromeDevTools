using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given vision deficiency.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetEmulatedVisionDeficiency)]
	[SupportedBy("Chrome")]
	public class SetEmulatedVisionDeficiencyCommandResponse
	{
	}
}
