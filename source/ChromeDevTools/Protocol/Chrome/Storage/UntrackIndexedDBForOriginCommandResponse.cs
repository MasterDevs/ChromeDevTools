using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for IndexedDB.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.UntrackIndexedDBForOrigin)]
	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForOriginCommandResponse
	{
	}
}
