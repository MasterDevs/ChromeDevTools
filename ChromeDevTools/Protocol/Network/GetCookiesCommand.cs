using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>
	[Command(ProtocolName.Network.GetCookies)]
	public class GetCookiesCommand
	{
	}
}
