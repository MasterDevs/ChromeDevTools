using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.ClearObjectStore)]
	public class ClearObjectStoreCommandResponse
	{
	}
}
