using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Runtime call counter information.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RuntimeCallCounterInfo
	{
		/// <summary>
		/// Gets or sets Counter name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Counter value.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Gets or sets Counter time in seconds.
		/// </summary>
		public double Time { get; set; }
	}
}
