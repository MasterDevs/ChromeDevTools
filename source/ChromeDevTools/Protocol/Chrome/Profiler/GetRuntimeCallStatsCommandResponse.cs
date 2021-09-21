using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Retrieve run time call stats.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.GetRuntimeCallStats)]
	[SupportedBy("Chrome")]
	public class GetRuntimeCallStatsCommandResponse
	{
		/// <summary>
		/// Gets or sets Collected runtime call counter information.
		/// </summary>
		public RuntimeCallCounterInfo[] Result { get; set; }
	}
}
