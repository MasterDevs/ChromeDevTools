using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetCurrentTime)]
	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommandResponse
	{
		/// <summary>
		/// Gets or sets Current time of the page.
		/// </summary>
		public double CurrentTime { get; set; }
	}
}
