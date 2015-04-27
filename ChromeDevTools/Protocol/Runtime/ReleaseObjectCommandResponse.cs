using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObject)]
	public class ReleaseObjectCommandResponse
	{
	}
}
