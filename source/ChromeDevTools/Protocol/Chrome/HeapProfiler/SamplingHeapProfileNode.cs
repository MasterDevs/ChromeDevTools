using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// Sampling Heap Profile node. Holds callsite information, allocation statistics and child nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfileNode
	{
		/// <summary>
		/// Gets or sets Function location.
		/// </summary>
		public Runtime.CallFrame CallFrame { get; set; }
		/// <summary>
		/// Gets or sets Allocations size in bytes for the node excluding children.
		/// </summary>
		public double SelfSize { get; set; }
		/// <summary>
		/// Gets or sets Child nodes.
		/// </summary>
		public SamplingHeapProfileNode[] Children { get; set; }
	}
}
