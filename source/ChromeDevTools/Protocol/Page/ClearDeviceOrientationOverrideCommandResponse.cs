using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommandResponse
	{
	}
}
