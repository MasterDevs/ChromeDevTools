using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceOrientation.SetDeviceOrientationOverride)]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}
