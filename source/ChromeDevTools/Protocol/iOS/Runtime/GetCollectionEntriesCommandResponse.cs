using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns entries of given Map / Set collection.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetCollectionEntries)]
	[SupportedBy("iOS")]
	public class GetCollectionEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of collection entries.
		/// </summary>
		public CollectionEntry[] Entries { get; set; }
	}
}
