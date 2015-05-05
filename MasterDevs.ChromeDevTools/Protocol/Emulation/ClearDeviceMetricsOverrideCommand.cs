using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearDeviceMetricsOverride)]
	public class ClearDeviceMetricsOverrideCommand
	{
	}
}
