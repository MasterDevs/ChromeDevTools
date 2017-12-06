using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Issued when new message was logged.
	/// </summary>
	[Event(ProtocolName.Log.EntryAdded)]
	[SupportedBy("Chrome")]
	public class EntryAddedEvent
	{
		/// <summary>
		/// Gets or sets The entry.
		/// </summary>
		public LogEntry Entry { get; set; }
	}
}
