using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Retrieve counters.
	/// </summary>
	[Command(ProtocolName.Profiler.GetCounters)]
	[SupportedBy("Chrome")]
	public class GetCountersCommand: ICommand<GetCountersCommandResponse>
	{
	}
}
