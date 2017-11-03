using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Enables log domain, sends the entries collected so far to the client by means of the <code>entryAdded</code> notification.
	/// </summary>
	[CommandResponse(ProtocolName.Log.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
