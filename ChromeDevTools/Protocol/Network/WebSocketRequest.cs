using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// WebSocket request data.
	/// </summary>
	public class WebSocketRequest
	{
		/// <summary>
		/// Gets or sets HTTP request headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
