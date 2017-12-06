using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowDebugBorders)]
	[SupportedBy("Chrome")]
	public class SetShowDebugBordersCommandResponse
	{
	}
}
