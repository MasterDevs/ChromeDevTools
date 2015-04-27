using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetTiming)]
	public class SetTimingCommandResponse
	{
	}
}
