using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Enables animation domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
