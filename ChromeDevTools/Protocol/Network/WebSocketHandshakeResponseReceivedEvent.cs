using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket handshake response becomes available.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketHandshakeResponseReceived)]
	public class WebSocketHandshakeResponseReceivedEvent
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
		/// Gets or sets WebSocket response data.
		/// </summary>
		public WebSocketResponse Response { get; set; }
	}
}
