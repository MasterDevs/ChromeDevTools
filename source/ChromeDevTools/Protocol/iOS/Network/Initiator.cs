using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Information about the request initiator.
	/// </summary>
	[SupportedBy("iOS")]
	public class Initiator
	{
		/// <summary>
		/// Gets or sets Type of this initiator.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Initiator JavaScript stack trace, set for Script only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Initiator URL, set for Parser type only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Initiator line number, set for Parser type only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LineNumber { get; set; }
	}
}
