using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ReplayXHR)]
	[SupportedBy("Chrome")]
	public class ReplayXHRCommandResponse
	{
	}
}
