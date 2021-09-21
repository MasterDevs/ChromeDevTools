using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>
	[Command(ProtocolName.Browser.ResetPermissions)]
	[SupportedBy("Chrome")]
	public class ResetPermissionsCommand: ICommand<ResetPermissionsCommandResponse>
	{
		/// <summary>
		/// Gets or sets BrowserContext to reset permissions. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
