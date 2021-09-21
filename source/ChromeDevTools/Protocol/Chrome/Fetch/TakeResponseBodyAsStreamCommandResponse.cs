using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Returns a handle to the stream representing the response body.
	/// The request must be paused in the HeadersReceived stage.
	/// Note that after this command the request can't be continued
	/// as is -- client either needs to cancel it or to provide the
	/// response body.
	/// The stream only supports sequential read, IO.read will fail if the position
	/// is specified.
	/// This method is mutually exclusive with getResponseBody.
	/// Calling other methods that affect the request or disabling fetch
	/// domain before body is received results in an undefined behavior.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.TakeResponseBodyAsStream)]
	[SupportedBy("Chrome")]
	public class TakeResponseBodyAsStreamCommandResponse
	{
		/// <summary>
		/// Gets or sets Stream
		/// </summary>
		public string Stream { get; set; }
	}
}
