using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies for the current URL. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>
	[Command(ProtocolName.Network.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets The list of URLs for which applicable cookies will be fetched
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Urls { get; set; }
	}
}
