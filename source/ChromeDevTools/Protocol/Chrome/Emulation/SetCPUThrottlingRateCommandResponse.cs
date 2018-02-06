using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables CPU throttling to emulate slow CPUs.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetCPUThrottlingRate)]
	[SupportedBy("Chrome")]
	public class SetCPUThrottlingRateCommandResponse
	{
	}
}
