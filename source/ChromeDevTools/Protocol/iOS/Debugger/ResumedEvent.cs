using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[Event(ProtocolName.Debugger.Resumed)]
	[SupportedBy("iOS")]
	public class ResumedEvent
	{
	}
}
