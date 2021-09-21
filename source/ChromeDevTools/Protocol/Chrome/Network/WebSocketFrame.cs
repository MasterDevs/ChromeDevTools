using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// WebSocket message data. This represents an entire WebSocket message, not just a fragmented frame as the name suggests.
	/// </summary>
	[SupportedBy("Chrome")]
	public class WebSocketFrame
	{
		/// <summary>
		/// Gets or sets WebSocket message opcode.
		/// </summary>
		public double Opcode { get; set; }
		/// <summary>
		/// Gets or sets WebSocket message mask.
		/// </summary>
		public bool Mask { get; set; }
		/// <summary>
		/// Gets or sets WebSocket message payload data.
		/// If the opcode is 1, this is a text message and payloadData is a UTF-8 string.
		/// If the opcode isn't 1, then payloadData is a base64 encoded string representing binary data.
		/// </summary>
		public string PayloadData { get; set; }
	}
}
