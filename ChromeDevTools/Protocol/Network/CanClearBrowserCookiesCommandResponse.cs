using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Network.CanClearBrowserCookies)]
	public class CanClearBrowserCookiesCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser cookies can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
