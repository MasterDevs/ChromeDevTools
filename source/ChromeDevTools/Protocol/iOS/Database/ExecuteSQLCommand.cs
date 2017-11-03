using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("iOS")]
	public class ExecuteSQLCommand: ICommand<ExecuteSQLCommandResponse>
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
