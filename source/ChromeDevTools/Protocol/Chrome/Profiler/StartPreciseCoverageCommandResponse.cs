using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code coverage may be incomplete. Enabling prevents running optimized code and resets execution counters.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.StartPreciseCoverage)]
	[SupportedBy("Chrome")]
	public class StartPreciseCoverageCommandResponse
	{
	}
}
