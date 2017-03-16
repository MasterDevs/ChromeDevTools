using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Releases a set of animations to no longer be manipulated.
	/// </summary>
	[Command(ProtocolName.Animation.ReleaseAnimations)]
	[SupportedBy("Chrome")]
	public class ReleaseAnimationsCommand
	{
		/// <summary>
		/// Gets or sets List of animation ids to seek.
		/// </summary>
		public string[] Animations { get; set; }
	}
}
