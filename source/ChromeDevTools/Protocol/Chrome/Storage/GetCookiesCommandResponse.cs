using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns all browser cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetCookies)]
	[SupportedBy("Chrome")]
	public class GetCookiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of cookie objects.
		/// </summary>
		public Network.Cookie[] Cookies { get; set; }
	}
}
