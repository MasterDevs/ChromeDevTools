using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemUpdated)]
	[SupportedBy("iOS")]
	public class DomStorageItemUpdatedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets OldValue
		/// </summary>
		public string OldValue { get; set; }
		/// <summary>
		/// Gets or sets NewValue
		/// </summary>
		public string NewValue { get; set; }
	}
}
