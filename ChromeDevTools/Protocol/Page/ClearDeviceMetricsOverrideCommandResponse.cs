using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearDeviceMetricsOverride)]
	public class ClearDeviceMetricsOverrideCommandResponse
	{
	}
}
