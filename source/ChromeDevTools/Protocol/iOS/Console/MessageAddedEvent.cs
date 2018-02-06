using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[Event(ProtocolName.Console.MessageAdded)]
	[SupportedBy("iOS")]
	public class MessageAddedEvent
	{
		/// <summary>
		/// Gets or sets Console message that has been added.
		/// </summary>
		public ConsoleMessage Message { get; set; }
	}
}
