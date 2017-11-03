using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowScrollBottleneckRects)]
	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommandResponse
	{
	}
}
