using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Prevents default drag and drop behavior and instead emits `Input.dragIntercepted` events.
	/// Drag and drop behavior can be directly controlled via `Input.dispatchDragEvent`.
	/// </summary>
	[CommandResponse(ProtocolName.Input.SetInterceptDrags)]
	[SupportedBy("Chrome")]
	public class SetInterceptDragsCommandResponse
	{
	}
}
