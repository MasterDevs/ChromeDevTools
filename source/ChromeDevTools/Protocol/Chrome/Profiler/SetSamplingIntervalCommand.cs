using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>
	[Command(ProtocolName.Profiler.SetSamplingInterval)]
	[SupportedBy("Chrome")]
	public class SetSamplingIntervalCommand: ICommand<SetSamplingIntervalCommandResponse>
	{
		/// <summary>
		/// Gets or sets New sampling interval in microseconds.
		/// </summary>
		public long Interval { get; set; }
	}
}
