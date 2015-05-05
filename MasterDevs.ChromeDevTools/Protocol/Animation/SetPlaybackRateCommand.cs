using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.SetPlaybackRate)]
	public class SetPlaybackRateCommand
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
