using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>
	[Command(ProtocolName.Profiler.SetSamplingInterval)]
	public class SetSamplingIntervalCommand
	{
		/// <summary>
		/// Gets or sets New sampling interval in microseconds.
		/// </summary>
		public long Interval { get; set; }
	}
}
