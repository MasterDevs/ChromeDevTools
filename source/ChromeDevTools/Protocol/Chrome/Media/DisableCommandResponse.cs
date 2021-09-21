using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Disables the Media domain.
	/// </summary>
	[CommandResponse(ProtocolName.Media.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
