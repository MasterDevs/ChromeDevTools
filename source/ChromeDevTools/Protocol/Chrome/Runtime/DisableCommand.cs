using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[Command(ProtocolName.Runtime.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
