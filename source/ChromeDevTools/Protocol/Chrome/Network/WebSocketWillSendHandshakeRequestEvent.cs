using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when WebSocket is about to initiate handshake.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketWillSendHandshakeRequest)]
	[SupportedBy("Chrome")]
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
