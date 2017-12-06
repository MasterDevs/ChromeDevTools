using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Response to Network.requestIntercepted which either modifies the request to continue with any modifications, or blocks it, or completes it with the provided response bytes. If a network fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted event will be sent with the same InterceptionId.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ContinueInterceptedRequest)]
	[SupportedBy("Chrome")]
	public class ContinueInterceptedRequestCommandResponse
	{
	}
}
