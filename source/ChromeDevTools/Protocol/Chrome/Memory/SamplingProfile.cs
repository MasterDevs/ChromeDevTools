using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Array of heap profile samples.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingProfile
	{
		/// <summary>
		/// Gets or sets Samples
		/// </summary>
		public SamplingProfileNode[] Samples { get; set; }
		/// <summary>
		/// Gets or sets Modules
		/// </summary>
		public Module[] Modules { get; set; }
	}
}
