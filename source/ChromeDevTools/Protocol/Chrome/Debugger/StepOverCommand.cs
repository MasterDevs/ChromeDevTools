using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOver)]
	[SupportedBy("Chrome")]
	public class StepOverCommand: ICommand<StepOverCommandResponse>
	{
	}
}
