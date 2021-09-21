using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowLayoutShiftRegions)]
	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommandResponse
	{
	}
}
