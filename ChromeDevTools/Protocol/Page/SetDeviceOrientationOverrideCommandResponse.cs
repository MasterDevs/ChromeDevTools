using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDeviceOrientationOverride)]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}
