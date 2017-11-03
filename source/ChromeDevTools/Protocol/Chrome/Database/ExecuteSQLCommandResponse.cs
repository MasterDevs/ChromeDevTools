using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[CommandResponse(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("Chrome")]
	public class ExecuteSQLCommandResponse
	{
		/// <summary>
		/// Gets or sets ColumnNames
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ColumnNames { get; set; }
		/// <summary>
		/// Gets or sets Values
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object[] Values { get; set; }
		/// <summary>
		/// Gets or sets SqlError
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Error SqlError { get; set; }
	}
}
