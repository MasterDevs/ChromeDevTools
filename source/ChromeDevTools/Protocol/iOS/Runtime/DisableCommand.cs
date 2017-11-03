using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[Command(ProtocolName.Runtime.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
