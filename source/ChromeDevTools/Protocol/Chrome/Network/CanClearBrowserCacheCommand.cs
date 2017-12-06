using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCacheCommand: ICommand<CanClearBrowserCacheCommandResponse>
	{
	}
}
