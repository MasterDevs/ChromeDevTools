using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virual time budget for the current VirtualTimePolicy has run out.
	/// </summary>
	[Event(ProtocolName.Emulation.VirtualTimeBudgetExpired)]
	[SupportedBy("Chrome")]
	public class VirtualTimeBudgetExpiredEvent
	{
	}
}
