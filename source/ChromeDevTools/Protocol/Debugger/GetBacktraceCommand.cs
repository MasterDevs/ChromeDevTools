using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns call stack including variables changed since VM was paused. VM must be paused.
	/// </summary>
	[Command(ProtocolName.Debugger.GetBacktrace)]
	public class GetBacktraceCommand
	{
	}
}
