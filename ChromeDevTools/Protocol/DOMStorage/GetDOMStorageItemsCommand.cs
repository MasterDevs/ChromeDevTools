using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	public class GetDOMStorageItemsCommand
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
