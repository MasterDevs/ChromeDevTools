using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[Event(ProtocolName.Profiler.ConsoleProfileFinished)]
	[SupportedBy("Chrome")]
	public class ConsoleProfileFinishedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profileEnd().
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile
		/// </summary>
		public Profile Profile { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as an argument to console.profile().
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }
	}
}
