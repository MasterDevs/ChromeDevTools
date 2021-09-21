using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Retrieve counters.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.GetCounters)]
	[SupportedBy("Chrome")]
	public class GetCountersCommandResponse
	{
		/// <summary>
		/// Gets or sets Collected counters information.
		/// </summary>
		public CounterInfo[] Result { get; set; }
	}
}
