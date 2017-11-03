using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
