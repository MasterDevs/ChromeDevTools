using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Gets metadata of an object store
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.GetMetadata)]
	[SupportedBy("Chrome")]
	public class GetMetadataCommandResponse
	{
		/// <summary>
		/// Gets or sets the entries count
		/// </summary>
		public double EntriesCount { get; set; }
		/// <summary>
		/// Gets or sets the current value of key generator, to become the next inserted
		/// key into the object store. Valid if objectStore.autoIncrement
		/// is true.
		/// </summary>
		public double KeyGeneratorValue { get; set; }
	}
}
