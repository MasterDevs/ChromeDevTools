using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[Command(ProtocolName.Page.ClearDeviceMetricsOverride)]
	public class ClearDeviceMetricsOverrideCommand
	{
	}
}
