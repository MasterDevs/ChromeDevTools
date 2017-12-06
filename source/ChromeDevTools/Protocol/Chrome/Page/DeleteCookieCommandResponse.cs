using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[CommandResponse(ProtocolName.Page.DeleteCookie)]
	[SupportedBy("Chrome")]
	public class DeleteCookieCommandResponse
	{
	}
}
