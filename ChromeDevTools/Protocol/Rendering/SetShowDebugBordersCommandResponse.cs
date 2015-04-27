using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowDebugBorders)]
	public class SetShowDebugBordersCommandResponse
	{
	}
}
