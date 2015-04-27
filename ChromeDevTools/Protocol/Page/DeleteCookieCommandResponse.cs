using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[CommandResponse(ProtocolName.Page.DeleteCookie)]
	public class DeleteCookieCommandResponse
	{
	}
}
