using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.Enable)]
	public class EnableCommandResponse
	{
	}
}
