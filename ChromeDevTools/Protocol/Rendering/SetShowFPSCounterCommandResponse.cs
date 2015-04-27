using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowFPSCounter)]
	public class SetShowFPSCounterCommandResponse
	{
	}
}
