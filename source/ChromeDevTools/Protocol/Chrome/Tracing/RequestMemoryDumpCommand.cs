using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Request a global memory dump.
	/// </summary>
	[Command(ProtocolName.Tracing.RequestMemoryDump)]
	[SupportedBy("Chrome")]
	public class RequestMemoryDumpCommand: ICommand<RequestMemoryDumpCommandResponse>
	{
	}
}
