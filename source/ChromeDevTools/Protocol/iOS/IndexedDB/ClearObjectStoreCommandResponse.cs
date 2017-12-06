using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.ClearObjectStore)]
	[SupportedBy("iOS")]
	public class ClearObjectStoreCommandResponse
	{
	}
}
