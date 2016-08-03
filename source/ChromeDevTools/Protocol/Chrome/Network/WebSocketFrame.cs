using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// WebSocket frame data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class WebSocketFrame
	{
		/// <summary>
		/// Gets or sets WebSocket frame opcode.
		/// </summary>
		public double Opcode { get; set; }
		/// <summary>
		/// Gets or sets WebSocke frame mask.
		/// </summary>
		public bool Mask { get; set; }
		/// <summary>
		/// Gets or sets WebSocke frame payload data.
		/// </summary>
		public string PayloadData { get; set; }
	}
}
