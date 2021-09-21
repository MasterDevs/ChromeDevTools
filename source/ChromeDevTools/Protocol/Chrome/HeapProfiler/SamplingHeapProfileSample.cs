using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// A single sample from a sampling profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfileSample
	{
		/// <summary>
		/// Gets or sets Allocation size in bytes attributed to the sample.
		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Gets or sets Id of the corresponding profile tree node.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Time-ordered sample ordinal number. It is unique across all profiles retrieved
		/// between startSampling and stopSampling.
		/// </summary>
		public double Ordinal { get; set; }
	}
}
