using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.Disable)]
	public class DisableCommandResponse
	{
	}
}
