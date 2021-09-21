using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when WebTransport is disposed.
	/// </summary>
	[Event(ProtocolName.Network.WebTransportClosed)]
	[SupportedBy("Chrome")]
	public class WebTransportClosedEvent
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
