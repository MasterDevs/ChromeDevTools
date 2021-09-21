using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Disable the WebAuthn domain.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
