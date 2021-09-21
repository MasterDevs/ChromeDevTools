using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	[Obsolete]
	[CommandResponse(ProtocolName.Debugger.PauseOnAsyncCall)]
	[SupportedBy("Chrome")]
	public class PauseOnAsyncCallCommandResponse
	{
	}
}
