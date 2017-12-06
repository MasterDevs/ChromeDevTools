using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Issued when subsequent message(s) are equal to the previous one(s).
	/// </summary>
	[Event(ProtocolName.Console.MessageRepeatCountUpdated)]
	[SupportedBy("iOS")]
	public class MessageRepeatCountUpdatedEvent
	{
		/// <summary>
		/// Gets or sets New repeat count value.
		/// </summary>
		public long Count { get; set; }
	}
}
