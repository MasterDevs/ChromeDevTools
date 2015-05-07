using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns entries of given collection.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetCollectionEntries)]
	public class GetCollectionEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of collection entries.
		/// </summary>
		public CollectionEntry[] Entries { get; set; }
	}
}
