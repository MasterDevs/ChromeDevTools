using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Timeline
{
	/// <summary>
	/// Deprecated.
	/// </summary>
	[Command(ProtocolName.Timeline.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand
	{
		/// <summary>
		/// Gets or sets Samples JavaScript stack traces up to <code>maxCallStackDepth</code>, defaults to 5.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxCallStackDepth { get; set; }
		/// <summary>
		/// Gets or sets Whether instrumentation events should be buffered and returned upon <code>stop</code> call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? BufferEvents { get; set; }
		/// <summary>
		/// Gets or sets Coma separated event types to issue although bufferEvents is set.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LiveEvents { get; set; }
		/// <summary>
		/// Gets or sets Whether counters data should be included into timeline events.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCounters { get; set; }
		/// <summary>
		/// Gets or sets Whether events from GPU process should be collected.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeGPUEvents { get; set; }
	}
}
