using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the current time of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.SetCurrentTime)]
	public class SetCurrentTimeCommand
	{
		/// <summary>
		/// Gets or sets Current time for the page animation timeline
		/// </summary>
		public double CurrentTime { get; set; }
	}
}
