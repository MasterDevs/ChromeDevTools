using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}
