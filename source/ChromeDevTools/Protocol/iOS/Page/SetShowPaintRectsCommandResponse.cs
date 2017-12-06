using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetShowPaintRects)]
	[SupportedBy("iOS")]
	public class SetShowPaintRectsCommandResponse
	{
	}
}
