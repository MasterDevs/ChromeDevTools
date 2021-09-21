using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetAppId)]
	[SupportedBy("Chrome")]
	public class GetAppIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Only returns a value if the feature flag 'WebAppEnableManifestId' is enabled
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AppId { get; set; }
	}
}
