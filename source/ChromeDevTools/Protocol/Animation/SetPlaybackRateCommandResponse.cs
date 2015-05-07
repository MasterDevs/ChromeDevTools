using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetPlaybackRate)]
	public class SetPlaybackRateCommandResponse
	{
	}
}
