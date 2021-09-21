using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues loading of the paused response, optionally modifying the
	/// response headers. If either responseCode or headers are modified, all of them
	/// must be present.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.ContinueResponse)]
	[SupportedBy("Chrome")]
	public class ContinueResponseCommandResponse
	{
	}
}
