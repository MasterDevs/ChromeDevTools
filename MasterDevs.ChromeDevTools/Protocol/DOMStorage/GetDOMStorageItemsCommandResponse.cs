using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.GetDOMStorageItems)]
	public class GetDOMStorageItemsCommandResponse
	{
		/// <summary>
		/// Gets or sets Entries
		/// </summary>
		public string[][] Entries { get; set; }
	}
}
