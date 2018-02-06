using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// HTTP request data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Request
	{
		/// <summary>
		/// Gets or sets Request URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets HTTP request method.
		/// </summary>
		public string Method { get; set; }
		/// <summary>
		/// Gets or sets HTTP request headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or sets HTTP POST request data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
		/// <summary>
		/// Gets or sets The mixed content type of the request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Security.MixedContentType MixedContentType { get; set; }
		/// <summary>
		/// Gets or sets Priority of the resource request at the time request is sent.
		/// </summary>
		public ResourcePriority InitialPriority { get; set; }
		/// <summary>
		/// Gets or sets The referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/
		/// </summary>
		public string ReferrerPolicy { get; set; }
		/// <summary>
		/// Gets or sets Whether is loaded via link preload.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsLinkPreload { get; set; }
	}
}
