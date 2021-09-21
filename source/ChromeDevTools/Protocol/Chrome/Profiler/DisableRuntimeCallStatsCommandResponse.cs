using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Disable run time call stats collection.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.DisableRuntimeCallStats)]
	[SupportedBy("Chrome")]
	public class DisableRuntimeCallStatsCommandResponse
	{
	}
}
