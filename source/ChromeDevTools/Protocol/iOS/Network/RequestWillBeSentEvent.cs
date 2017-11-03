using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when page is about to send HTTP request.
	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("iOS")]
	public class RequestWillBeSentEvent
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
		/// Gets or sets URL of the document this request is loaded for.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Request data.
		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or sets Redirect response data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Page.ResourceType Type { get; set; }
	}
}
