using ChromeDevTools;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Called when global has been cleared and debugger client should reset its state. Happens upon navigation or reload.
	/// </summary>
	[Event(ProtocolName.Debugger.GlobalObjectCleared)]
	public class GlobalObjectClearedEvent
	{
	}
}
