using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[CommandResponse(ProtocolName.Overlay.SetShowScrollSnapOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowScrollSnapOverlaysCommandResponse
	{
	}
}
