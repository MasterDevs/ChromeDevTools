using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Provides response to the request.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.FulfillRequest)]
	[SupportedBy("Chrome")]
	public class FulfillRequestCommandResponse
	{
	}
}
