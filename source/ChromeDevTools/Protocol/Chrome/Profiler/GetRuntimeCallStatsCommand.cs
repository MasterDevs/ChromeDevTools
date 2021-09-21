using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Retrieve run time call stats.
	/// </summary>
	[Command(ProtocolName.Profiler.GetRuntimeCallStats)]
	[SupportedBy("Chrome")]
	public class GetRuntimeCallStatsCommand: ICommand<GetRuntimeCallStatsCommandResponse>
	{
	}
}
