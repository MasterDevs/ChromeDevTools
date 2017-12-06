using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Enables type profiling on the VM.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.EnableTypeProfiler)]
	[SupportedBy("iOS")]
	public class EnableTypeProfilerCommandResponse
	{
	}
}
