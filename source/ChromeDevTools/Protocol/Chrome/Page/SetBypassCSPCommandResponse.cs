using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enable page Content Security Policy by-passing.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetBypassCSP)]
	[SupportedBy("Chrome")]
	public class SetBypassCSPCommandResponse
	{
	}
}
