using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when handling requests for resources within a .wbn file.
	/// Note: this will only be fired for resources that are requested by the webpage.
	/// </summary>
	[Event(ProtocolName.Network.SubresourceWebBundleInnerResponseParsed)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleInnerResponseParsedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier of the subresource request
		/// </summary>
		public string InnerRequestId { get; set; }
		/// <summary>
		/// Gets or sets URL of the subresource resource.
		/// </summary>
		public string InnerRequestURL { get; set; }
		/// <summary>
		/// Gets or sets Bundle request identifier. Used to match this information to another event.
		/// This made be absent in case when the instrumentation was enabled only
		/// after webbundle was parsed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BundleRequestId { get; set; }
	}
}
