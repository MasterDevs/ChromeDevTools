using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.SetScrollbarsHidden)]
	[SupportedBy("Chrome")]
	public class SetScrollbarsHiddenCommandResponse
	{
	}
}
