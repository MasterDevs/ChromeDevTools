using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearDeviceMetricsOverride)]
	public class ClearDeviceMetricsOverrideCommandResponse
	{
	}
}
