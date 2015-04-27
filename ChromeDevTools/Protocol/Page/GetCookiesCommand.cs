using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>
	[Command(ProtocolName.Page.GetCookies)]
	public class GetCookiesCommand
	{
	}
}
