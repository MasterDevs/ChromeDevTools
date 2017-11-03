using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	[Command(ProtocolName.Memory.PrepareForLeakDetection)]
	[SupportedBy("Chrome")]
	public class PrepareForLeakDetectionCommand: ICommand<PrepareForLeakDetectionCommandResponse>
	{
	}
}
