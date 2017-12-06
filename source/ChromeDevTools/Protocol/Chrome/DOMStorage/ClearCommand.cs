using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Command(ProtocolName.DOMStorage.Clear)]
	[SupportedBy("Chrome")]
	public class ClearCommand: ICommand<ClearCommandResponse>
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
