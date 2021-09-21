using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues the request, optionally modifying some of its parameters.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.ContinueRequest)]
	[SupportedBy("Chrome")]
	public class ContinueRequestCommandResponse
	{
	}
}
