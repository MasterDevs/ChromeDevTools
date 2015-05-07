using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Keyframe Style
	/// </summary>
	public class KeyframeStyle
	{
		/// <summary>
		/// Gets or sets Keyframe's time offset.
		/// </summary>
		public string Offset { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
