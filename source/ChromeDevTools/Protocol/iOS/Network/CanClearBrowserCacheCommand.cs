using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("iOS")]
	public class CanClearBrowserCacheCommand: ICommand<CanClearBrowserCacheCommandResponse>
	{
	}
}
