using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[Command(ProtocolName.FileSystem.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand
	{
	}
}
