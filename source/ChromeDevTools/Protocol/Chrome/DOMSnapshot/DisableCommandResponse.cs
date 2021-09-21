using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Disables DOM snapshot agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.DOMSnapshot.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
