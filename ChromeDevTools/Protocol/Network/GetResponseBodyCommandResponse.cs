using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetResponseBody)]
	public class GetResponseBodyCommandResponse
	{
		/// <summary>
		/// Gets or sets Response body.
		/// </summary>
		public string Body { get; set; }
		/// <summary>
		/// Gets or sets True, if content was sent as base64.
		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
