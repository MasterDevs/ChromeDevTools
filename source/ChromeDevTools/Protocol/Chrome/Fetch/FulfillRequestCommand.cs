using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Provides response to the request.
	/// </summary>
	[Command(ProtocolName.Fetch.FulfillRequest)]
	[SupportedBy("Chrome")]
	public class FulfillRequestCommand: ICommand<FulfillRequestCommandResponse>
	{
		/// <summary>
		/// Gets or sets An id the client received in requestPaused event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets An HTTP response code.
		/// </summary>
		public long ResponseCode { get; set; }
		/// <summary>
		/// Gets or sets Response headers.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeaderEntry[] ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or sets Alternative way of specifying response headers as a \0-separated
		/// series of name: value pairs. Prefer the above method unless you
		/// need to represent some non-UTF8 values that can't be transmitted
		/// over the protocol as text. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BinaryResponseHeaders { get; set; }
		/// <summary>
		/// Gets or sets A response body. If absent, original response body will be used if
		/// the request is intercepted at the response stage and empty body
		/// will be used if the request is intercepted at the request stage. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Body { get; set; }
		/// <summary>
		/// Gets or sets A textual representation of responseCode.
		/// If absent, a standard phrase matching responseCode is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ResponsePhrase { get; set; }
	}
}
