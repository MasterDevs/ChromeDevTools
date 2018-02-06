using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Enables console domain, sends the messages collected so far to the client by means of the <code>messageAdded</code> notification.
	/// </summary>
	[CommandResponse(ProtocolName.Console.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
