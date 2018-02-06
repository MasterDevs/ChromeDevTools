using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when data chunk was received over the network.
	/// </summary>
	[Event(ProtocolName.Network.DataReceived)]
	[SupportedBy("Chrome")]
	public class DataReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Data chunk length.
		/// </summary>
		public long DataLength { get; set; }
		/// <summary>
		/// Gets or sets Actual bytes received (might be less than dataLength for compressed encodings).
		/// </summary>
		public long EncodedDataLength { get; set; }
	}
}
