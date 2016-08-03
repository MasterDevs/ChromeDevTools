using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Rendering
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowPaintRects)]
	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommandResponse
	{
	}
}
