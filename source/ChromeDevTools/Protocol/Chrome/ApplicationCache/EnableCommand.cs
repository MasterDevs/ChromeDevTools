using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ApplicationCache
{
	/// <summary>
	/// Enables application cache domain notifications.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
