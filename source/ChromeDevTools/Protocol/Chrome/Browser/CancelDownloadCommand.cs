using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>
	[Command(ProtocolName.Browser.CancelDownload)]
	[SupportedBy("Chrome")]
	public class CancelDownloadCommand: ICommand<CancelDownloadCommandResponse>
	{
		/// <summary>
		/// Gets or sets Global unique identifier of the download.
		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// Gets or sets BrowserContext to perform the action in. When omitted, default browser context is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
