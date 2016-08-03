using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// WebSocket request data.
	/// </summary>
	[SupportedBy("iOS")]
	public class WebSocketRequest
	{
		/// <summary>
		/// Gets or sets HTTP response headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
