using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[Command(ProtocolName.Page.ClearDeviceMetricsOverride)]
	public class ClearDeviceMetricsOverrideCommand
	{
	}
}
