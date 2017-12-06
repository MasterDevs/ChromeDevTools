using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.QueryObjects)]
	[SupportedBy("Chrome")]
	public class QueryObjectsCommand: ICommand<QueryObjectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the prototype to return objects for.
		/// </summary>
		public string PrototypeObjectId { get; set; }
	}
}
