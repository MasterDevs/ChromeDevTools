using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Disables Canvas inspection.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.Disable)]
	public class DisableCommandResponse
	{
	}
}
