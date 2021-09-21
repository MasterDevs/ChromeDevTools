using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when WebTransport handshake is finished.
	/// </summary>
	[Event(ProtocolName.Network.WebTransportConnectionEstablished)]
	[SupportedBy("Chrome")]
	public class WebTransportConnectionEstablishedEvent
	{
		/// <summary>
		/// Gets or sets WebTransport identifier.
		/// </summary>
		public string TransportId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
