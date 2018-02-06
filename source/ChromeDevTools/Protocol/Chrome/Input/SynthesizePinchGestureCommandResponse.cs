using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[CommandResponse(ProtocolName.Input.SynthesizePinchGesture)]
	[SupportedBy("Chrome")]
	public class SynthesizePinchGestureCommandResponse
	{
	}
}
