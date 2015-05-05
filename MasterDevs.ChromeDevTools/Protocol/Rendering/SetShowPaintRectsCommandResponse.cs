using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowPaintRects)]
	public class SetShowPaintRectsCommandResponse
	{
	}
}
