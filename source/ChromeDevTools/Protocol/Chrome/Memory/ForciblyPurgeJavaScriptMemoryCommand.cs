using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate OomIntervention by purging V8 memory.
	/// </summary>
	[Command(ProtocolName.Memory.ForciblyPurgeJavaScriptMemory)]
	[SupportedBy("Chrome")]
	public class ForciblyPurgeJavaScriptMemoryCommand: ICommand<ForciblyPurgeJavaScriptMemoryCommandResponse>
	{
	}
}
