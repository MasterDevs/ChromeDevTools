using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[Command(ProtocolName.Network.GetResponseBody)]
	public class GetResponseBodyCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
