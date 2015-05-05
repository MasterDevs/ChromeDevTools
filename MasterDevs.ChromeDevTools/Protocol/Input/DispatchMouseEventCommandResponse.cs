using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Dispatches a mouse event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchMouseEvent)]
	public class DispatchMouseEventCommandResponse
	{
	}
}
