using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when WebSocket frame is received.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameReceived)]
	[SupportedBy("iOS")]
	public class WebSocketFrameReceivedEvent
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
		public WebSocketFrame Response { get; set; }
	}
}
