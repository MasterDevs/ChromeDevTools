using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCookiesCommandResponse
	{
	}
}
