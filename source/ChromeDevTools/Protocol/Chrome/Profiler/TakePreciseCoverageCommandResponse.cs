using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate, and resets execution counters. Precise code coverage needs to have started.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.TakePreciseCoverage)]
	[SupportedBy("Chrome")]
	public class TakePreciseCoverageCommandResponse
	{
		/// <summary>
		/// Gets or sets Coverage data for the current isolate.
		/// </summary>
		public ScriptCoverage[] Result { get; set; }
	}
}
