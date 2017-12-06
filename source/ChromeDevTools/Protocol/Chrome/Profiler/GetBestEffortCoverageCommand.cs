using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate. The coverage data may be incomplete due to garbage collection.
	/// </summary>
	[Command(ProtocolName.Profiler.GetBestEffortCoverage)]
	[SupportedBy("Chrome")]
	public class GetBestEffortCoverageCommand: ICommand<GetBestEffortCoverageCommandResponse>
	{
	}
}
