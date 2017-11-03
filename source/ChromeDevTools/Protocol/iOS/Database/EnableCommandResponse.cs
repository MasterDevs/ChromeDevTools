using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	/// Enables database tracking, database events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Database.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
