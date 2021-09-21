using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set permission settings for given origin.
	/// </summary>
	[Command(ProtocolName.Browser.SetPermission)]
	[SupportedBy("Chrome")]
	public class SetPermissionCommand: ICommand<SetPermissionCommandResponse>
	{
		/// <summary>
		/// Gets or sets Descriptor of permission to override.
		/// </summary>
		public PermissionDescriptor Permission { get; set; }
		/// <summary>
		/// Gets or sets Setting of the permission.
		/// </summary>
		public string Setting { get; set; }
		/// <summary>
		/// Gets or sets Origin the permission applies to, all origins if not specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Context to override. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
