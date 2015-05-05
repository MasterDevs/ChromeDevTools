using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[Command(ProtocolName.Inspector.Disable)]
	public class DisableCommand
	{
	}
}
