using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceOrientation.SetDeviceOrientationOverride)]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}
