using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired upon WebSocket creation.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketCreated)]
	public class WebSocketCreatedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets WebSocket request URL.
		/// </summary>
		public string Url { get; set; }
	}
}
