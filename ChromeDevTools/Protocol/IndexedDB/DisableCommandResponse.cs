using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.Disable)]
	public class DisableCommandResponse
	{
	}
}
