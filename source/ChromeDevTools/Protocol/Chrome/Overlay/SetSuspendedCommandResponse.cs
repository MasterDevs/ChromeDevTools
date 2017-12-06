using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[CommandResponse(ProtocolName.Overlay.SetSuspended)]
	[SupportedBy("Chrome")]
	public class SetSuspendedCommandResponse
	{
	}
}
