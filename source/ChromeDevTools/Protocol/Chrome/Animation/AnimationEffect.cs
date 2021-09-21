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
		/// Gets or sets `AnimationEffect`'s delay.
		/// </summary>
		public double Delay { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s end delay.
		/// </summary>
		public double EndDelay { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s iteration start.
		/// </summary>
		public double IterationStart { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s iterations.
		/// </summary>
		public double Iterations { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s iteration duration.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s playback direction.
		/// </summary>
		public string Direction { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s fill mode.
		/// </summary>
		public string Fill { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s target node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s keyframes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyframesRule KeyframesRule { get; set; }
		/// <summary>
		/// Gets or sets `AnimationEffect`'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
