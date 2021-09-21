using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match the provided patterns and optionally resource types.
	/// Deprecated, please use Fetch.enable instead.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Network.SetRequestInterception)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommandResponse
	{
	}
}
