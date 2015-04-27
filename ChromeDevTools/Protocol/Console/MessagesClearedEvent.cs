using ChromeDevTools;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Issued when console is cleared. This happens either upon <code>clearMessages</code> command or after page navigation.
	/// </summary>
	[Event(ProtocolName.Console.MessagesCleared)]
	public class MessagesClearedEvent
	{
	}
}
