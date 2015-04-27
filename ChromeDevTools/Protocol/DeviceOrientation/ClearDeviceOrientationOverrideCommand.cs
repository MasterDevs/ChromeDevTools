using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Command(ProtocolName.DeviceOrientation.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommand
	{
	}
}
