using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when EventSource message is received.
	/// </summary>
	[Event(ProtocolName.Network.EventSourceMessageReceived)]
	[SupportedBy("Chrome")]
	public class EventSourceMessageReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Message type.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets Message identifier.
		/// </summary>
		public string EventId { get; set; }
		/// <summary>
		/// Gets or sets Message content.
		/// </summary>
		public string Data { get; set; }
	}
}
