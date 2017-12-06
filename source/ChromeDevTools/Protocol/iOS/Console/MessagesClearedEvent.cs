using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Issued when console is cleared. This happens either upon <code>clearMessages</code> command or after page navigation.
	/// </summary>
	[Event(ProtocolName.Console.MessagesCleared)]
	[SupportedBy("iOS")]
	public class MessagesClearedEvent
	{
	}
}
