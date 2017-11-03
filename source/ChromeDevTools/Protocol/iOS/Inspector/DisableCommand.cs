using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[Command(ProtocolName.Inspector.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
