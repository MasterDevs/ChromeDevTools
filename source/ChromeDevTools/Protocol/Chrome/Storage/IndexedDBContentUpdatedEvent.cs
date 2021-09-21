using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// The origin's IndexedDB object store has been modified.
	/// </summary>
	[Event(ProtocolName.Storage.IndexedDBContentUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBContentUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Origin to update.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Database to update.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets ObjectStore to update.
		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
