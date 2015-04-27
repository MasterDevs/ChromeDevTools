using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetPlaybackRate)]
	public class SetPlaybackRateCommandResponse
	{
	}
}
