using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or mocked.
	/// </summary>
	[Event(ProtocolName.Network.RequestIntercepted)]
	[SupportedBy("Chrome")]
	public class RequestInterceptedEvent
	{
		/// <summary>
		/// Gets or sets Each request the page makes will have a unique id, however if any redirects are encountered while processing that fetch, they will be reported with the same id as the original fetch. Likewise if HTTP authentication is needed then the same fetch id will be used.
		/// </summary>
		public string InterceptionId { get; set; }
		/// <summary>
		/// Gets or sets Request
		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or sets How the requested resource will be used.
		/// </summary>
		public Page.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets Whether this is a navigation request, which can abort the navigation completely.
		/// </summary>
		public bool IsNavigationRequest { get; set; }
		/// <summary>
		/// Gets or sets HTTP response headers, only sent if a redirect was intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> RedirectHeaders { get; set; }
		/// <summary>
		/// Gets or sets HTTP response code, only sent if a redirect was intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RedirectStatusCode { get; set; }
		/// <summary>
		/// Gets or sets Redirect location, only sent if a redirect was intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RedirectUrl { get; set; }
		/// <summary>
		/// Gets or sets Details of the Authorization Challenge encountered. If this is set then continueInterceptedRequest must contain an authChallengeResponse.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AuthChallenge AuthChallenge { get; set; }
	}
}
