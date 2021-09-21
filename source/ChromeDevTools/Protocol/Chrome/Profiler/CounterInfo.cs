using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collected counter information.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CounterInfo
	{
		/// <summary>
		/// Gets or sets Counter name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Counter value.
		/// </summary>
		public long Value { get; set; }
	}
}
