using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a drag event into the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchDragEvent)]
	[SupportedBy("Chrome")]
	public class DispatchDragEventCommandResponse
	{
	}
}
