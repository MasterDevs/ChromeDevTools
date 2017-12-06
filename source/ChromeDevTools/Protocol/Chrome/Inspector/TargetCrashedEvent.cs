using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[Event(ProtocolName.Inspector.TargetCrashed)]
	[SupportedBy("Chrome")]
	public class TargetCrashedEvent
	{
	}
}
