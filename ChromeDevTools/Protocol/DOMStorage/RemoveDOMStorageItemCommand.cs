using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	[Command(ProtocolName.DOMStorage.RemoveDOMStorageItem)]
	public class RemoveDOMStorageItemCommand
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
