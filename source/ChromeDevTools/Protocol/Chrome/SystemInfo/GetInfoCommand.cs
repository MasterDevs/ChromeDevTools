using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the system.
	/// </summary>
	[Command(ProtocolName.SystemInfo.GetInfo)]
	[SupportedBy("Chrome")]
	public class GetInfoCommand: ICommand<GetInfoCommandResponse>
	{
	}
}
