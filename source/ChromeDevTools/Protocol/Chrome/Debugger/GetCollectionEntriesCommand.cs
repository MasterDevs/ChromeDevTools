using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns entries of given collection.
	/// </summary>
	[Command(ProtocolName.Debugger.GetCollectionEntries)]
	[SupportedBy("Chrome")]
	public class GetCollectionEntriesCommand
	{
		/// <summary>
		/// Gets or sets Id of the collection to get entries for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
