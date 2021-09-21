using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetManifestIcons)]
	[SupportedBy("Chrome")]
	public class GetManifestIconsCommandResponse
	{
		/// <summary>
		/// Gets or sets PrimaryIcon
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrimaryIcon { get; set; }
	}
}
