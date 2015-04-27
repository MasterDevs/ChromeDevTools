using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	/// <summary>
	/// Enables database tracking, database events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.Database.Enable)]
	public class EnableCommand
	{
	}
}
