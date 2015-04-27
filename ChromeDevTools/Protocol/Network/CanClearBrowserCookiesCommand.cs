using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCookies)]
	public class CanClearBrowserCookiesCommand
	{
	}
}
