using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	[Command(ProtocolName.DOMStorage.SetDOMStorageItem)]
	public class SetDOMStorageItemCommand
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
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
	}
}
