using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[Command(ProtocolName.Page.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommand: ICommand<ClearDeviceMetricsOverrideCommandResponse>
	{
	}
}
