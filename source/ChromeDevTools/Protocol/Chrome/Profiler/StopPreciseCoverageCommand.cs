using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Disable precise code coverage. Disabling releases unnecessary execution count records and allows executing optimized code.
	/// </summary>
	[Command(ProtocolName.Profiler.StopPreciseCoverage)]
	[SupportedBy("Chrome")]
	public class StopPreciseCoverageCommand: ICommand<StopPreciseCoverageCommandResponse>
	{
	}
}
