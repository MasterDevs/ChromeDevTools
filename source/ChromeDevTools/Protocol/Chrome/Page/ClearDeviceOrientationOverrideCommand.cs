using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.ClearDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommand: ICommand<ClearDeviceOrientationOverrideCommandResponse>
	{
	}
}
