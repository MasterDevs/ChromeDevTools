using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Delete a range of entries from an object store
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.DeleteObjectStoreEntries)]
	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommandResponse
	{
	}
}
