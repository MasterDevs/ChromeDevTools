using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	public class GetDatabaseTableNamesCommand
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
