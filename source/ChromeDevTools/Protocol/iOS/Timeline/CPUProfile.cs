using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("iOS")]
	public class CPUProfile
	{
		/// <summary>
		/// Gets or sets Top level nodes in the stack.
		/// </summary>
		public CPUProfileNode[] RootNodes { get; set; }
		/// <summary>
		/// Gets or sets IdleTime
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double IdleTime { get; set; }
	}
}
