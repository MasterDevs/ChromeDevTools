using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetAppManifest)]
	[SupportedBy("Chrome")]
	public class GetAppManifestCommandResponse
	{
		/// <summary>
		/// Gets or sets Manifest location.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Errors
		/// </summary>
		public AppManifestError[] Errors { get; set; }
		/// <summary>
		/// Gets or sets Manifest content.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Data { get; set; }
	}
}
