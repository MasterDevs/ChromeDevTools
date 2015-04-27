using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.Enable)]
	public class EnableCommandResponse
	{
	}
}
