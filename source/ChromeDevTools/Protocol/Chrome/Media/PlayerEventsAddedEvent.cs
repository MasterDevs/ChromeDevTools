using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Send events as a list, allowing them to be batched on the browser for less
	/// congestion. If batched, events must ALWAYS be in chronological order.
	/// </summary>
	[Event(ProtocolName.Media.PlayerEventsAdded)]
	[SupportedBy("Chrome")]
	public class PlayerEventsAddedEvent
	{
		/// <summary>
		/// Gets or sets PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Gets or sets Events
		/// </summary>
		public PlayerEvent[] Events { get; set; }
	}
}
