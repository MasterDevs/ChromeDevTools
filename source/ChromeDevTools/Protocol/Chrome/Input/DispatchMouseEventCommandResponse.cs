using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a mouse event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchMouseEvent)]
	[SupportedBy("Chrome")]
	public class DispatchMouseEventCommandResponse
	{
	}
}
