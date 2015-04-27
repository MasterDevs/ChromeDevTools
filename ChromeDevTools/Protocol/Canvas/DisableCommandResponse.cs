using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Disables Canvas inspection.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.Disable)]
	public class DisableCommandResponse
	{
	}
}
