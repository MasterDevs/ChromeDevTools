using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>
	[Command(ProtocolName.Debugger.Pause)]
	[SupportedBy("iOS")]
	public class PauseCommand: ICommand<PauseCommandResponse>
	{
	}
}
