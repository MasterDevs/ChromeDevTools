using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues loading of the paused response, optionally modifying the
	/// response headers. If either responseCode or headers are modified, all of them
	/// must be present.
	/// </summary>
	[Command(ProtocolName.Fetch.ContinueResponse)]
	[SupportedBy("Chrome")]
	public class ContinueResponseCommand: ICommand<ContinueResponseCommandResponse>
	{
		/// <summary>
		/// Gets or sets An id the client received in requestPaused event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets An HTTP response code. If absent, original response code will be used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ResponseCode { get; set; }
		/// <summary>
		/// Gets or sets A textual representation of responseCode.
		/// If absent, a standard phrase matching responseCode is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ResponsePhrase { get; set; }
		/// <summary>
		/// Gets or sets Response headers. If absent, original response headers will be used.
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
	}
}
