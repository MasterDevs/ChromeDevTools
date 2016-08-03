using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[Command(ProtocolName.FileSystem.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand
	{
	}
}
