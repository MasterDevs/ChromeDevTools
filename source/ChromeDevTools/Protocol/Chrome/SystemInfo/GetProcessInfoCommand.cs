using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about all running processes.
	/// </summary>
	[Command(ProtocolName.SystemInfo.GetProcessInfo)]
	[SupportedBy("Chrome")]
	public class GetProcessInfoCommand: ICommand<GetProcessInfoCommandResponse>
	{
	}
}
