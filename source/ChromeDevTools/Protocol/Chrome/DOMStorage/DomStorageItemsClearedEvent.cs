using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("Chrome")]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
