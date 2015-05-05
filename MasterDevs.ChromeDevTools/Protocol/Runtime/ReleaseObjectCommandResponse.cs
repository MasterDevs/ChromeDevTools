using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObject)]
	public class ReleaseObjectCommandResponse
	{
	}
}
