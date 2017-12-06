using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>
	[Command(ProtocolName.Animation.GetCurrentTime)]
	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommand: ICommand<GetCurrentTimeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of animation.
		/// </summary>
		public string Id { get; set; }
	}
}
