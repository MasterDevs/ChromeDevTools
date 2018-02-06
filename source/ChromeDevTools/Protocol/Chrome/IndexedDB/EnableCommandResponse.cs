using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
