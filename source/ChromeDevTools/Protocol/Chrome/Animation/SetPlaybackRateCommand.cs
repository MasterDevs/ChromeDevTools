using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.SetPlaybackRate)]
	[SupportedBy("Chrome")]
	public class SetPlaybackRateCommand: ICommand<SetPlaybackRateCommandResponse>
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
