using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for origin.
	/// </summary>
	[Command(ProtocolName.Storage.ClearDataForOrigin)]
	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommand: ICommand<ClearDataForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Comma separated origin names.
		/// </summary>
		public string StorageTypes { get; set; }
	}
}
