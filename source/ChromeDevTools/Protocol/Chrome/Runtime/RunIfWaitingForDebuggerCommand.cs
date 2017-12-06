using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Tells inspected instance to run if it was waiting for debugger to attach.
	/// </summary>
	[Command(ProtocolName.Runtime.RunIfWaitingForDebugger)]
	[SupportedBy("Chrome")]
	public class RunIfWaitingForDebuggerCommand: ICommand<RunIfWaitingForDebuggerCommandResponse>
	{
	}
}
