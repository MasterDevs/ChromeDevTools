using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetPageScaleFactor)]
	public class SetPageScaleFactorCommandResponse
	{
	}
}
