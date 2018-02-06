using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.ClearObjectStore)]
	[SupportedBy("Chrome")]
	public class ClearObjectStoreCommandResponse
	{
	}
}
