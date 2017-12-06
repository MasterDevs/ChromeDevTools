using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetFramesWithManifests)]
	[SupportedBy("iOS")]
	public class GetFramesWithManifestsCommand: ICommand<GetFramesWithManifestsCommandResponse>
	{
	}
}
