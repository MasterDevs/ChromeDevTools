using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Sent when new profile recording is started using console.profile() call.
	/// </summary>
	[Event(ProtocolName.Profiler.ConsoleProfileStarted)]
	[SupportedBy("Chrome")]
	public class ConsoleProfileStartedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profile().
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as an argument to console.profile().
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }
	}
}
