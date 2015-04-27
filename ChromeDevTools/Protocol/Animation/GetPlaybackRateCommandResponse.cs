using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetPlaybackRate)]
	public class GetPlaybackRateCommandResponse
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page.
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
