using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.SetSamplingInterval)]
	public class SetSamplingIntervalCommandResponse
	{
	}
}
