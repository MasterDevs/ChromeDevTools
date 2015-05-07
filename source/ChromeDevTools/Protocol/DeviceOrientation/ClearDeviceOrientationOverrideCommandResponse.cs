using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceOrientation.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommandResponse
	{
	}
}
