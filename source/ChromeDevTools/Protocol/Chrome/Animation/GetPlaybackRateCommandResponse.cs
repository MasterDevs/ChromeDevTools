using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetPlaybackRate)]
	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommandResponse
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page.
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
