using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a touch event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchTouchEvent)]
	[SupportedBy("Chrome")]
	public class DispatchTouchEventCommandResponse
	{
	}
}
