using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// Sampling profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfile
	{
		/// <summary>
		/// Gets or sets Head
		/// </summary>
		public SamplingHeapProfileNode Head { get; set; }
		/// <summary>
		/// Gets or sets Samples
		/// </summary>
		public SamplingHeapProfileSample[] Samples { get; set; }
	}
}
