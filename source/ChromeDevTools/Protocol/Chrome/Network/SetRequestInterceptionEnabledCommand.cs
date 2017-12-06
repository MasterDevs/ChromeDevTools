using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match a the provided patterns.
	/// </summary>
	[Command(ProtocolName.Network.SetRequestInterceptionEnabled)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionEnabledCommand: ICommand<SetRequestInterceptionEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether requests should be intercepted. If patterns is not set, matches all and resets any previously set patterns. Other parameters are ignored if false.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets URLs matching any of these patterns will be forwarded and wait for the corresponding continueInterceptedRequest call. Wildcards ('*' -> zero or more, '?' -> exactly one) are allowed. Escape character is backslash. If omitted equivalent to ['*'] (intercept all).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Patterns { get; set; }
	}
}
