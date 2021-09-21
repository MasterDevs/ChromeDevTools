using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate OomIntervention by purging V8 memory.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.ForciblyPurgeJavaScriptMemory)]
	[SupportedBy("Chrome")]
	public class ForciblyPurgeJavaScriptMemoryCommandResponse
	{
	}
}
