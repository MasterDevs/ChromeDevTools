using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Causes the body of the response to be received from the server and
	/// returned as a single string. May only be issued for a request that
	/// is paused in the Response stage and is mutually exclusive with
	/// takeResponseBodyForInterceptionAsStream. Calling other methods that
	/// affect the request or disabling fetch domain before body is received
	/// results in an undefined behavior.
	/// </summary>
	[Command(ProtocolName.Fetch.GetResponseBody)]
	[SupportedBy("Chrome")]
	public class GetResponseBodyCommand: ICommand<GetResponseBodyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier for the intercepted request to get body for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
