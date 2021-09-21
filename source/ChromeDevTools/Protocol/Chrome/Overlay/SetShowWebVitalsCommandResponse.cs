using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Request that backend shows an overlay with web vital metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowWebVitals)]
	[SupportedBy("Chrome")]
	public class SetShowWebVitalsCommandResponse
	{
	}
}
