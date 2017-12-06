using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome")]
	public class DeleteCacheCommandResponse
	{
	}
}
