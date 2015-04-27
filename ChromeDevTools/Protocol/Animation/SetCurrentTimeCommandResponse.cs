using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the current time of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetCurrentTime)]
	public class SetCurrentTimeCommandResponse
	{
	}
}
