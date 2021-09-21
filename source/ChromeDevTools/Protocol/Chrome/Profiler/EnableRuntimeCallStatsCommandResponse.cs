using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable run time call stats collection.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.EnableRuntimeCallStats)]
	[SupportedBy("Chrome")]
	public class EnableRuntimeCallStatsCommandResponse
	{
	}
}
