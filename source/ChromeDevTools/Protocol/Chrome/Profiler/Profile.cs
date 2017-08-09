using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CPUProfile
	{
		/// <summary>
		/// Gets or sets Head
		/// </summary>
		public CPUProfileNode Head { get; set; }
		/// <summary>
		/// Gets or sets Profiling start time in seconds.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets Profiling end time in seconds.
		/// </summary>
		public double EndTime { get; set; }
		/// <summary>
		/// Gets or sets Ids of samples top nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] Samples { get; set; }
		/// <summary>
		/// Gets or sets Timestamps of the samples in microseconds.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[] Timestamps { get; set; }
	}
}
