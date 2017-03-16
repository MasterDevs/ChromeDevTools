using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("iOS")]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
