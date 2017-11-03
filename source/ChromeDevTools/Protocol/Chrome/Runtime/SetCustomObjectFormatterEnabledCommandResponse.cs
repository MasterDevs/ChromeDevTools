using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[CommandResponse(ProtocolName.Runtime.SetCustomObjectFormatterEnabled)]
	[SupportedBy("Chrome")]
	public class SetCustomObjectFormatterEnabledCommandResponse
	{
	}
}
