using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}
