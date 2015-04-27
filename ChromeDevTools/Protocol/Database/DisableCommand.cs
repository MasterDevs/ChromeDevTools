using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	/// <summary>
	/// Disables database tracking, prevents database events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.Database.Disable)]
	public class DisableCommand
	{
	}
}
