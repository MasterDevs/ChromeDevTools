using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCookie)]
	[SupportedBy("Chrome")]
	public class SetCookieCommandResponse
	{
		/// <summary>
		/// Gets or sets True if successfully set cookie.
		/// </summary>
		public bool Success { get; set; }
	}
}
