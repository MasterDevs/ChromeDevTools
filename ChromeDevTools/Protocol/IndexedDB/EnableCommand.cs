using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[Command(ProtocolName.IndexedDB.Enable)]
	public class EnableCommand
	{
	}
}
