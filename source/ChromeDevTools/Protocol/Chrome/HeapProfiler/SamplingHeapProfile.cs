using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfile
	{
		/// <summary>
		/// Gets or sets Head
		/// </summary>
		public SamplingHeapProfileNode Head { get; set; }
	}
}
