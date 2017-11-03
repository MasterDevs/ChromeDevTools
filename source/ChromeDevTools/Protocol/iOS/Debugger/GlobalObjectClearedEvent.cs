using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Called when global has been cleared and debugger client should reset its state. Happens upon navigation or reload.
	/// </summary>
	[Event(ProtocolName.Debugger.GlobalObjectCleared)]
	[SupportedBy("iOS")]
	public class GlobalObjectClearedEvent
	{
	}
}
