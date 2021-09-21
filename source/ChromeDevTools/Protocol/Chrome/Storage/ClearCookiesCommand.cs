using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears cookies.
	/// </summary>
	[Command(ProtocolName.Storage.ClearCookies)]
	[SupportedBy("Chrome")]
	public class ClearCookiesCommand: ICommand<ClearCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
