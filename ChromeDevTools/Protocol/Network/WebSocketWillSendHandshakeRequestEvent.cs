using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket is about to initiate handshake.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketWillSendHandshakeRequest)]
	public class WebSocketWillSendHandshakeRequestEvent
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
		/// Gets or sets UTC Timestamp.
		/// </summary>
		public double WallTime { get; set; }
		/// <summary>
		/// Gets or sets WebSocket request data.
		/// </summary>
		public WebSocketRequest Request { get; set; }
	}
}
