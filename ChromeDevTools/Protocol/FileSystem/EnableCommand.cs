using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[Command(ProtocolName.FileSystem.Enable)]
	public class EnableCommand
	{
	}
}
