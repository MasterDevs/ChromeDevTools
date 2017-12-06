using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("iOS")]
	public class ClearBrowserCookiesCommand: ICommand<ClearBrowserCookiesCommandResponse>
	{
	}
}
