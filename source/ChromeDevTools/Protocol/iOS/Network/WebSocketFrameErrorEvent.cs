using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when WebSocket frame error occurs.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("iOS")]
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
