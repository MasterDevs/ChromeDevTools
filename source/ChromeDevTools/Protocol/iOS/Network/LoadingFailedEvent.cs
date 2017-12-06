using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when HTTP request has failed to load.
	/// </summary>
	[Event(ProtocolName.Network.LoadingFailed)]
	[SupportedBy("iOS")]
	public class LoadingFailedEvent
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
		/// Gets or sets User friendly error message.
		/// </summary>
		public string ErrorText { get; set; }
		/// <summary>
		/// Gets or sets True if loading was canceled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
	}
}
