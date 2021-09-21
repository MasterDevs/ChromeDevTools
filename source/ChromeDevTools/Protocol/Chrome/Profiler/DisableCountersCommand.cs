using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Disable counters collection.
	/// </summary>
	[Command(ProtocolName.Profiler.DisableCounters)]
	[SupportedBy("Chrome")]
	public class DisableCountersCommand: ICommand<DisableCountersCommandResponse>
	{
	}
}
