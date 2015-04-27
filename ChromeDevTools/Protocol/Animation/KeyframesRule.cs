using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Keyframes Rule
	/// </summary>
	public class KeyframesRule
	{
		/// <summary>
		/// Gets or sets CSS keyframed animation's name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets List of animation keyframes.
		/// </summary>
		public KeyframeStyle[] Keyframes { get; set; }
	}
}
