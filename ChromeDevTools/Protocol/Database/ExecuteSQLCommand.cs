using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	public class ExecuteSQLCommand
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
		/// <summary>
		/// Gets or sets Query
		/// </summary>
		public string Query { get; set; }
	}
}
