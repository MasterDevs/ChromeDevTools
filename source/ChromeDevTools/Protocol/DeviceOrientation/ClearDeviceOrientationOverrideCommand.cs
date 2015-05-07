using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Command(ProtocolName.DeviceOrientation.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommand
	{
	}
}
