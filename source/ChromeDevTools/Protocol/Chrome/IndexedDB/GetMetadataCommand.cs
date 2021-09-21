using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Gets metadata of an object store
	/// </summary>
	[Command(ProtocolName.IndexedDB.GetMetadata)]
	[SupportedBy("Chrome")]
	public class GetMetadataCommand: ICommand<GetMetadataCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets Object store name.
		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
