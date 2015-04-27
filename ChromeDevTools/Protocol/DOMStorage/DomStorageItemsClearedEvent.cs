using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
