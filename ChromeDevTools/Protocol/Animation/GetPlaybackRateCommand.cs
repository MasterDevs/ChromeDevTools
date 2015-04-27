using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.GetPlaybackRate)]
	public class GetPlaybackRateCommand
	{
	}
}
