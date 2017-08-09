using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired upon WebSocket creation.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketCreated)]
	[SupportedBy("Chrome")]
	public class WebSocketCreatedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets WebSocket request URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
	}
}
