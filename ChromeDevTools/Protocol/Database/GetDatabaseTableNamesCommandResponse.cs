using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	[CommandResponse(ProtocolName.Database.GetDatabaseTableNames)]
	public class GetDatabaseTableNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}
