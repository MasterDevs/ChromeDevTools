using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[CommandResponse(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("iOS")]
	public class GetDatabaseTableNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
