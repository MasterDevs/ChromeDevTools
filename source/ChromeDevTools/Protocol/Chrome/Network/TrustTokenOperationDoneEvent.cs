using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired exactly once for each Trust Token operation. Depending on
	/// the type of the operation and whether the operation succeeded or
	/// failed, the event is fired before the corresponding request was sent
	/// or after the response was received.
	/// </summary>
	[Event(ProtocolName.Network.TrustTokenOperationDone)]
	[SupportedBy("Chrome")]
	public class TrustTokenOperationDoneEvent
	{
		/// <summary>
		/// Gets or sets Detailed success or error status of the operation.
		/// 'AlreadyExists' also signifies a successful operation, as the result
		/// of the operation already exists und thus, the operation was abort
		/// preemptively (e.g. a cache hit).
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public TrustTokenOperationType Type { get; set; }
		/// <summary>
		/// Gets or sets RequestId
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Top level origin. The context in which the operation was attempted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TopLevelOrigin { get; set; }
		/// <summary>
		/// Gets or sets Origin of the issuer in case of a "Issuance" or "Redemption" operation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string IssuerOrigin { get; set; }
		/// <summary>
		/// Gets or sets The number of obtained Trust Tokens on a successful "Issuance" operation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? IssuedTokenCount { get; set; }
	}
}
