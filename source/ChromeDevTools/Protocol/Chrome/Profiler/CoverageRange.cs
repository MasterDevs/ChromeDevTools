using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Coverage data for a source range.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CoverageRange
	{
		/// <summary>
		/// Gets or sets JavaScript script source offset for the range start.
		/// </summary>
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script source offset for the range end.
		/// </summary>
		public long EndOffset { get; set; }
		/// <summary>
		/// Gets or sets Collected execution count of the source range.
		/// </summary>
		public long Count { get; set; }
	}
}
