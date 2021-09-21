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
		/// Gets or sets Always set to true. If an error occurs, the response indicates protocol error.
		/// </summary>
		public bool Success { get; set; }
	}
}
