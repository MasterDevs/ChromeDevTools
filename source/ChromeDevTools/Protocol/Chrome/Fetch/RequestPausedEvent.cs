using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Issued when the domain is enabled and the request URL matches the
	/// specified filter. The request is paused until the client responds
	/// with one of continueRequest, failRequest or fulfillRequest.
	/// The stage of the request can be determined by presence of responseErrorReason
	/// and responseStatusCode -- the request is at the response stage if either
	/// of these fields is present and in the request stage otherwise.
	/// </summary>
	[Event(ProtocolName.Fetch.RequestPaused)]
	[SupportedBy("Chrome")]
	public class RequestPausedEvent
	{
		/// <summary>
		/// Gets or sets Each request the page makes will have a unique id.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets The details of the request.
		/// </summary>
		public Network.Request Request { get; set; }
		/// <summary>
		/// Gets or sets The id of the frame that initiated the request.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets How the requested resource will be used.
		/// </summary>
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets Response error if intercepted at response stage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ErrorReason ResponseErrorReason { get; set; }
		/// <summary>
		/// Gets or sets Response code if intercepted at response stage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ResponseStatusCode { get; set; }
		/// <summary>
		/// Gets or sets Response status text if intercepted at response stage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ResponseStatusText { get; set; }
		/// <summary>
		/// Gets or sets Response headers if intercepted at the response stage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeaderEntry[] ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or sets If the intercepted request had a corresponding Network.requestWillBeSent event fired for it,
		/// then this networkId will be the same as the requestId present in the requestWillBeSent event.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkId { get; set; }
	}
}
