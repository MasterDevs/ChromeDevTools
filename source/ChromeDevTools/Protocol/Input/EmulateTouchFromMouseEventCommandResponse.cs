using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[CommandResponse(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	public class EmulateTouchFromMouseEventCommandResponse
	{
	}
}
