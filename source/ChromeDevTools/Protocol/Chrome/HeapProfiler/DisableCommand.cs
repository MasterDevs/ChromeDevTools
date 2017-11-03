using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
