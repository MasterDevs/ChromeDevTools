using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Enables console domain, sends the messages collected so far to the client by means of the <code>messageAdded</code> notification.
	/// </summary>
	[Command(ProtocolName.Console.Enable)]
	public class EnableCommand
	{
	}
}
