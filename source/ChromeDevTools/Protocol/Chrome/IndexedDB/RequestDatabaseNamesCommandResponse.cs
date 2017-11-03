using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Database names for origin.
		/// </summary>
		public string[] DatabaseNames { get; set; }
	}
}
