using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCookies)]
	public class ClearBrowserCookiesCommand
	{
	}
}
