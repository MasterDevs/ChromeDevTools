using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemRemoved)]
	[SupportedBy("Chrome")]
	public class DomStorageItemRemovedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public string Key { get; set; }
	}
}
