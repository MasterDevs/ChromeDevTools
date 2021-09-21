using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable run time call stats collection.
	/// </summary>
	[Command(ProtocolName.Profiler.EnableRuntimeCallStats)]
	[SupportedBy("Chrome")]
	public class EnableRuntimeCallStatsCommand: ICommand<EnableRuntimeCallStatsCommandResponse>
	{
	}
}
