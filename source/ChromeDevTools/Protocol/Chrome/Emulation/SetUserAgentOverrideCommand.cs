using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[Command(ProtocolName.Emulation.SetUserAgentOverride)]
	[SupportedBy("Chrome")]
	public class SetUserAgentOverrideCommand: ICommand<SetUserAgentOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets User agent to use.
		/// </summary>
		public string UserAgent { get; set; }
		/// <summary>
		/// Gets or sets Browser langugage to emulate.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AcceptLanguage { get; set; }
		/// <summary>
		/// Gets or sets The platform navigator.platform should return.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Platform { get; set; }
		/// <summary>
		/// Gets or sets To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UserAgentMetadata UserAgentMetadata { get; set; }
	}
}
