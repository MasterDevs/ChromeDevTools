using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetPageScaleFactor)]
	public class SetPageScaleFactorCommandResponse
	{
	}
}
