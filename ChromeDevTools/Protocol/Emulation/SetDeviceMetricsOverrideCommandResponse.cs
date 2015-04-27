using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetDeviceMetricsOverride)]
	public class SetDeviceMetricsOverrideCommandResponse
	{
	}
}
