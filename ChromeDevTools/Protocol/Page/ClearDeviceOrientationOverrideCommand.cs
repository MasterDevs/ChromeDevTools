using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>
	[Command(ProtocolName.Page.ClearDeviceOrientationOverride)]
	public class ClearDeviceOrientationOverrideCommand
	{
	}
}
