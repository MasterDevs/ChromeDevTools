using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	[CommandResponse(ProtocolName.Memory.PrepareForLeakDetection)]
	[SupportedBy("Chrome")]
	public class PrepareForLeakDetectionCommandResponse
	{
	}
}
