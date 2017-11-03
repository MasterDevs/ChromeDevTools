using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("iOS")]
	public class CanClearBrowserCookiesCommand: ICommand<CanClearBrowserCookiesCommandResponse>
	{
	}
}
