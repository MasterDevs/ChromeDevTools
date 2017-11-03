using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Enables animation domain notifications.
	/// </summary>
	[Command(ProtocolName.Animation.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
