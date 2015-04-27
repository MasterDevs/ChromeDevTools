using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObjectGroup)]
	public class ReleaseObjectGroupCommandResponse
	{
	}
}
