using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[CommandResponse(ProtocolName.Runtime.QueryObjects)]
	[SupportedBy("Chrome")]
	public class QueryObjectsCommandResponse
	{
		/// <summary>
		/// Gets or sets Array with objects.
		/// </summary>
		public RemoteObject Objects { get; set; }
	}
}
