using ChromeDevTools;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[Event(ProtocolName.Console.MessageAdded)]
	public class MessageAddedEvent
	{
		/// <summary>
		/// Gets or sets Console message that has been added.
		/// </summary>
		public ConsoleMessage Message { get; set; }
	}
}
