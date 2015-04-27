using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[CommandResponse(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	public class EmulateTouchFromMouseEventCommandResponse
	{
	}
}
