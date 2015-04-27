using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket frame error occurs.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameError)]
	public class WebSocketFrameErrorEvent
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
		/// Gets or sets WebSocket frame error message.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
