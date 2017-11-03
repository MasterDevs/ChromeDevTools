using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	[SupportedBy("Chrome")]
	public class TraceConfig
	{
		/// <summary>
		/// Gets or sets Controls how the trace buffer stores data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RecordMode { get; set; }
		/// <summary>
		/// Gets or sets Turns on JavaScript stack sampling.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableSampling { get; set; }
		/// <summary>
		/// Gets or sets Turns on system tracing.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableSystrace { get; set; }
		/// <summary>
		/// Gets or sets Turns on argument filter.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableArgumentFilter { get; set; }
		/// <summary>
		/// Gets or sets Included category filters.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] IncludedCategories { get; set; }
		/// <summary>
		/// Gets or sets Excluded category filters.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ExcludedCategories { get; set; }
		/// <summary>
		/// Gets or sets Configuration to synthesize the delays in tracing.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] SyntheticDelays { get; set; }
		/// <summary>
		/// Gets or sets Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MemoryDumpConfig MemoryDumpConfig { get; set; }
	}
}
