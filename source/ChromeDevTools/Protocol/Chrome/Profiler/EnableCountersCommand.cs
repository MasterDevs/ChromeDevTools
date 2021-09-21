using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable counters collection.
	/// </summary>
	[Command(ProtocolName.Profiler.EnableCounters)]
	[SupportedBy("Chrome")]
	public class EnableCountersCommand: ICommand<EnableCountersCommandResponse>
	{
	}
}
