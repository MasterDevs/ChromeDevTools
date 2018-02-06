using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
	/// </summary>
	[Event(ProtocolName.Emulation.VirtualTimeBudgetExpired)]
	[SupportedBy("Chrome")]
	public class VirtualTimeBudgetExpiredEvent
	{
	}
}
