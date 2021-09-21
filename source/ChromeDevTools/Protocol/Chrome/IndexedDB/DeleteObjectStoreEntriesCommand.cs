using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Delete a range of entries from an object store
	/// </summary>
	[Command(ProtocolName.IndexedDB.DeleteObjectStoreEntries)]
	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommand: ICommand<DeleteObjectStoreEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or sets SecurityOrigin
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets DatabaseName
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets ObjectStoreName
		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or sets Range of entry keys to delete
		/// </summary>
		public KeyRange KeyRange { get; set; }
	}
}
