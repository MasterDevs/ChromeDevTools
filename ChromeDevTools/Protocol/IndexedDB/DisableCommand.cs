using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[Command(ProtocolName.IndexedDB.Disable)]
	public class DisableCommand
	{
	}
}
