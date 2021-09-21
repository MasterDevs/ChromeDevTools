using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
	/// mocked.
	/// Deprecated, use Fetch.requestPaused instead.
	/// </summary>
	[Event(ProtocolName.Network.RequestIntercepted)]
	[SupportedBy("Chrome")]
	public class RequestInterceptedEvent
	{
		/// <summary>
		/// Gets or sets Each request the page makes will have a unique id, however if any redirects are encountered
		/// while processing that fetch, they will be reported with the same id as the original fetch.
		/// Likewise if HTTP authentication is needed then the same fetch id will be used.
		/// </summary>
		public string InterceptionId { get; set; }
		/// <summary>
		/// Gets or sets Request
		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or sets The id of the frame that initiated the request.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets How the requested resource will be used.
		/// </summary>
		public ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets Whether this is a navigation request, which can abort the navigation completely.
		/// </summary>
		public bool IsNavigationRequest { get; set; }
		/// <summary>
		/// Gets or sets Set if the request is a navigation that will result in a download.
		/// Only present after response is received from the server (i.e. HeadersReceived stage).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsDownload { get; set; }
		/// <summary>
		/// Gets or sets Redirect location, only sent if a redirect was intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RedirectUrl { get; set; }
		/// <summary>
		/// Gets or sets Details of the Authorization Challenge encountered. If this is set then
		/// continueInterceptedRequest must contain an authChallengeResponse.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AuthChallenge AuthChallenge { get; set; }
		/// <summary>
		/// Gets or sets Response error if intercepted at response stage or if redirect occurred while intercepting
		/// request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ErrorReason ResponseErrorReason { get; set; }
		/// <summary>
		/// Gets or sets Response code if intercepted at response stage or if redirect occurred while intercepting
		/// request or auth retry occurred.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ResponseStatusCode { get; set; }
		/// <summary>
		/// Gets or sets Response headers if intercepted at the response stage or if redirect occurred while
		/// intercepting request or auth retry occurred.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or sets If the intercepted request had a corresponding requestWillBeSent event fired for it, then
		/// This requestId will be the same as the requestId present in the requestWillBeSent event.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
