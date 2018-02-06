using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("iOS")]
	public class CanClearBrowserCookiesCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser cookies can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
