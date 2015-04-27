using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.DeleteCache)]
	public class DeleteCacheCommandResponse
	{
	}
}
