using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDeviceMetricsOverride)]
	public class SetDeviceMetricsOverrideCommandResponse
	{
	}
}
