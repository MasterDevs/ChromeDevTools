using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows hit-test borders on layers
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowHitTestBorders)]
	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommandResponse
	{
	}
}
