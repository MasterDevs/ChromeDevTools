using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[Command(ProtocolName.FileSystem.Disable)]
	public class DisableCommand
	{
	}
}
