using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowViewportSizeOnResize)]
	[SupportedBy("Chrome")]
	public class SetShowViewportSizeOnResizeCommandResponse
	{
	}
}
