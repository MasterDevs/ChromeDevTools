using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>
	[Command(ProtocolName.Target.GetTargets)]
	[SupportedBy("Chrome")]
	public class GetTargetsCommand: ICommand<GetTargetsCommandResponse>
	{
	}
}
