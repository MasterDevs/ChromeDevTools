using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when a signed exchange was received over the network
	/// </summary>
	[Event(ProtocolName.Network.SignedExchangeReceived)]
	[SupportedBy("Chrome")]
	public class SignedExchangeReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Information about the signed exchange response.
		/// </summary>
		public SignedExchangeInfo Info { get; set; }
	}
}
