using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Clears the log.
	/// </summary>
	[CommandResponse(ProtocolName.Log.Clear)]
	[SupportedBy("Chrome")]
	public class ClearCommandResponse
	{
	}
}
