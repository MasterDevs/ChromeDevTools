using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Causes the request to fail with specified reason.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.FailRequest)]
	[SupportedBy("Chrome")]
	public class FailRequestCommandResponse
	{
	}
}
