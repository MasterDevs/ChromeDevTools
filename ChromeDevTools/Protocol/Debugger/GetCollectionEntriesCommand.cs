using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns entries of given collection.
	/// </summary>
	[Command(ProtocolName.Debugger.GetCollectionEntries)]
	public class GetCollectionEntriesCommand
	{
		/// <summary>
		/// Gets or sets Id of the collection to get entries for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
