using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome")]
	public class TraceConfig
	{
		/// <summary>
		/// Gets or sets Controls how the trace buffer stores data.
		/// </summary>
		public string RecordMode { get; set; }
		/// <summary>
		/// Gets or sets Turns on JavaScript stack sampling.
		/// </summary>
		public bool EnableSampling { get; set; }
		/// <summary>
		/// Gets or sets Turns on system tracing.
		/// </summary>
		public bool EnableSystrace { get; set; }
		/// <summary>
		/// Gets or sets Turns on argument filter.
		/// </summary>
		public bool EnableArgumentFilter { get; set; }
		/// <summary>
		/// Gets or sets Included category filters.
		/// </summary>
		public string[] IncludedCategories { get; set; }
		/// <summary>
		/// Gets or sets Excluded category filters.
		/// </summary>
		public string[] ExcludedCategories { get; set; }
		/// <summary>
		/// Gets or sets Configuration to synthesize the delays in tracing.
		/// </summary>
		public string[] SyntheticDelays { get; set; }
		/// <summary>
		/// Gets or sets Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
		/// </summary>
		public MemoryDumpConfig MemoryDumpConfig { get; set; }
	}
}
