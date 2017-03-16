using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Information about the cached resource.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CachedResource
	{
		/// <summary>
		/// Gets or sets Resource URL. This is the url of the original network request.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Cached response data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response Response { get; set; }
		/// <summary>
		/// Gets or sets Cached response body size.
		/// </summary>
		public double BodySize { get; set; }
	}
}
