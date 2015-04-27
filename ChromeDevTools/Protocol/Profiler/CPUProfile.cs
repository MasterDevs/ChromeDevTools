using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Profile.
	/// </summary>
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
		public long[] Samples { get; set; }
		/// <summary>
		/// Gets or sets Timestamps of the samples in microseconds.
		/// </summary>
		public double[] Timestamps { get; set; }
	}
}
