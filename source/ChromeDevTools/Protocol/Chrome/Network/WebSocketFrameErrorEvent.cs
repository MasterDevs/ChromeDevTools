using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when WebSocket frame error occurs.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("Chrome")]
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
