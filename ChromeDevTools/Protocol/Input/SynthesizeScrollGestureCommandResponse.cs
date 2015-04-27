using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[CommandResponse(ProtocolName.Input.SynthesizeScrollGesture)]
	public class SynthesizeScrollGestureCommandResponse
	{
	}
}
