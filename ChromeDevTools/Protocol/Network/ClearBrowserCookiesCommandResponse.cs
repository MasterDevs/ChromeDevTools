using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCookies)]
	public class ClearBrowserCookiesCommandResponse
	{
	}
}
