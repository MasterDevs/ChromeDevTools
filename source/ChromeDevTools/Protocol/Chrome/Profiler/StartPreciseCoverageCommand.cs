using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code coverage may be incomplete. Enabling prevents running optimized code and resets execution counters.
	/// </summary>
	[Command(ProtocolName.Profiler.StartPreciseCoverage)]
	[SupportedBy("Chrome")]
	public class StartPreciseCoverageCommand: ICommand<StartPreciseCoverageCommandResponse>
	{
		/// <summary>
		/// Gets or sets Collect accurate call counts beyond simple 'covered' or 'not covered'.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CallCount { get; set; }
		/// <summary>
		/// Gets or sets Collect block-based coverage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Detailed { get; set; }
	}
}
