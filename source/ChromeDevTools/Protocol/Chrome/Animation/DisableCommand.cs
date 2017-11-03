using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Disables animation domain notifications.
	/// </summary>
	[Command(ProtocolName.Animation.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
