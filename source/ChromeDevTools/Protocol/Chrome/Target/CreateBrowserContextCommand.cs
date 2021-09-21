using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
	/// one.
	/// </summary>
	[Command(ProtocolName.Target.CreateBrowserContext)]
	[SupportedBy("Chrome")]
	public class CreateBrowserContextCommand: ICommand<CreateBrowserContextCommandResponse>
	{
		/// <summary>
		/// Gets or sets If specified, disposes this context when debugging session disconnects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisposeOnDetach { get; set; }
		/// <summary>
		/// Gets or sets Proxy server, similar to the one passed to --proxy-server
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ProxyServer { get; set; }
		/// <summary>
		/// Gets or sets Proxy bypass list, similar to the one passed to --proxy-bypass-list
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ProxyBypassList { get; set; }
	}
}
