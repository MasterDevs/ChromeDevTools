using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Steps into the first async operation handler that was scheduled by or after the current statement.
	/// </summary>
	[Command(ProtocolName.Debugger.StepIntoAsync)]
	public class StepIntoAsyncCommand
	{
	}
}
