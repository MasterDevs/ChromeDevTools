using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	/// Disables database tracking, prevents database events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.Database.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
