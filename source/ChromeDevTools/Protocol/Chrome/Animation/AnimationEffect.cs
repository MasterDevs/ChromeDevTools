using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// AnimationEffect instance
	/// </summary>
	[SupportedBy("Chrome")]
	public class AnimationEffect
	{
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s delay.
		/// </summary>
		public double Delay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s end delay.
		/// </summary>
		public double EndDelay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s iteration start.
		/// </summary>
		public double IterationStart { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s iterations.
		/// </summary>
		public double Iterations { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s iteration duration.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s playback direction.
		/// </summary>
		public string Direction { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s fill mode.
		/// </summary>
		public string Fill { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s target node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s keyframes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyframesRule KeyframesRule { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationEffect</code>'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
