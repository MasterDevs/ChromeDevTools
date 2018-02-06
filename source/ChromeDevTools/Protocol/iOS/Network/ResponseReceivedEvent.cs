using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when HTTP response is available.
	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("iOS")]
	public class ResponseReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Response data.
		/// </summary>
		public Response Response { get; set; }
	}
}
