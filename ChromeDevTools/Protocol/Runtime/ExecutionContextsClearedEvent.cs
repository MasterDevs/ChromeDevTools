using ChromeDevTools;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Issued when all executionContexts were cleared in browser
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextsCleared)]
	public class ExecutionContextsClearedEvent
	{
	}
}
