using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	[SupportedBy("Chrome")]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Gets or sets Database
		/// </summary>
		public Database Database { get; set; }
	}
}
