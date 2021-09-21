using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Enables DOM snapshot agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.DOMSnapshot.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
