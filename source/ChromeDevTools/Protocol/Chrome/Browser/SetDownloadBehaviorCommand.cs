using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>
	[Command(ProtocolName.Browser.SetDownloadBehavior)]
	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommand: ICommand<SetDownloadBehaviorCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to allow all or deny all download requests, or use default Chrome behavior if
		/// available (otherwise deny). |allowAndName| allows download and names files according to
		/// their dowmload guids.
		/// </summary>
		public string Behavior { get; set; }
		/// <summary>
		/// Gets or sets BrowserContext to set download behavior. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// Gets or sets The default path to save downloaded files to. This is required if behavior is set to 'allow'
		/// or 'allowAndName'.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DownloadPath { get; set; }
		/// <summary>
		/// Gets or sets Whether to emit download events (defaults to false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EventsEnabled { get; set; }
	}
}
