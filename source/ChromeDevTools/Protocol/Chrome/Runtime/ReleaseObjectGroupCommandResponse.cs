using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.ReleaseObjectGroup)]
	[SupportedBy("Chrome")]
	public class ReleaseObjectGroupCommandResponse
	{
	}
}
