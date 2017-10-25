using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Information about the Resource on the page.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FrameResource
	{
		/// <summary>
		/// Gets or sets Resource URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets last-modified timestamp as reported by server.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LastModified { get; set; }
		/// <summary>
		/// Gets or sets Resource content size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ContentSize { get; set; }
		/// <summary>
		/// Gets or sets True if the resource failed to load.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Failed { get; set; }
		/// <summary>
		/// Gets or sets True if the resource was canceled during loading.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
	}
}
