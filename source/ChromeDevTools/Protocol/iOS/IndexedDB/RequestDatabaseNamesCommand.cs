using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("iOS")]
	public class RequestDatabaseNamesCommand: ICommand<RequestDatabaseNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}
