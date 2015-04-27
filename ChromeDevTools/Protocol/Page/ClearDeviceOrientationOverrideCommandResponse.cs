using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommandResponse
	{
	}
}
