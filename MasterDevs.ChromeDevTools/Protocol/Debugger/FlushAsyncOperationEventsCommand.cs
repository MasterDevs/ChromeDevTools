using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fires pending <code>asyncOperationStarted</code> events (if any), as if a debugger stepping session has just been started.
	/// </summary>
	[Command(ProtocolName.Debugger.FlushAsyncOperationEvents)]
	public class FlushAsyncOperationEventsCommand
	{
	}
}
