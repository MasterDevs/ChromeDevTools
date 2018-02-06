using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommandResponse
	{
	}
}
