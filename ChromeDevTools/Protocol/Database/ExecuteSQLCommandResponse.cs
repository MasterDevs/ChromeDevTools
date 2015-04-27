using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	[CommandResponse(ProtocolName.Database.ExecuteSQL)]
	public class ExecuteSQLCommandResponse
	{
		/// <summary>
		/// Gets or sets ColumnNames
		/// </summary>
		public string[] ColumnNames { get; set; }
		/// <summary>
		/// Gets or sets Values
		/// </summary>
		public object[] Values { get; set; }
		/// <summary>
		/// Gets or sets SqlError
		/// </summary>
		public Error SqlError { get; set; }
	}
}
