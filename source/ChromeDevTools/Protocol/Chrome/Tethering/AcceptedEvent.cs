using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Informs that port was successfully bound and got a specified connection id.
	/// </summary>
	[Event(ProtocolName.Tethering.Accepted)]
	[SupportedBy("Chrome")]
	public class AcceptedEvent
	{
		/// <summary>
		/// Gets or sets Port number that was successfully bound.
		/// </summary>
		public long Port { get; set; }
		/// <summary>
		/// Gets or sets Connection id to be used.
		/// </summary>
		public string ConnectionId { get; set; }
	}
}
