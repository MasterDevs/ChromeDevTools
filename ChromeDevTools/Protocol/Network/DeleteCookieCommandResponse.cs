using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[CommandResponse(ProtocolName.Network.DeleteCookie)]
	public class DeleteCookieCommandResponse
	{
	}
}
