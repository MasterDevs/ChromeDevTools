using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match a the provided patterns.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetRequestInterceptionEnabled)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionEnabledCommandResponse
	{
	}
}
