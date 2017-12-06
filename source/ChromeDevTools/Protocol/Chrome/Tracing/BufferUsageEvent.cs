using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	[Event(ProtocolName.Tracing.BufferUsage)]
	[SupportedBy("Chrome")]
	public class BufferUsageEvent
	{
		/// <summary>
		/// Gets or sets A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double PercentFull { get; set; }
		/// <summary>
		/// Gets or sets An approximate number of events in the trace log.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double EventCount { get; set; }
		/// <summary>
		/// Gets or sets A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Value { get; set; }
	}
}
