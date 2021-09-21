using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Enables issuing of requestPaused events. A request will be paused until client
	/// calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
	/// </summary>
	[Command(ProtocolName.Fetch.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
		/// <summary>
		/// Gets or sets If specified, only requests matching any of these patterns will produce
		/// fetchRequested event and will be paused until clients response. If not set,
		/// all requests will be affected.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RequestPattern[] Patterns { get; set; }
		/// <summary>
		/// Gets or sets If true, authRequired events will be issued and requests will be paused
		/// expecting a call to continueWithAuth.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HandleAuthRequests { get; set; }
	}
}
