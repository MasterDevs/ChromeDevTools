using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Enables tracking security state changes.
	/// </summary>
	[CommandResponse(ProtocolName.Security.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
