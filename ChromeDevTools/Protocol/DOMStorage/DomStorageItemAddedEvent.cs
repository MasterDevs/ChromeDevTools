using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemAdded)]
	public class DomStorageItemAddedEvent
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
		/// Gets or sets NewValue
		/// </summary>
		public string NewValue { get; set; }
	}
}
