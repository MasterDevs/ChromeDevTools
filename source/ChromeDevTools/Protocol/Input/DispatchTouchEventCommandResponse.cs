using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Dispatches a touch event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchTouchEvent)]
	public class DispatchTouchEventCommandResponse
	{
	}
}
