using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// AnimationNode instance
	/// </summary>
	public class AnimationNode
	{
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s delay.
		/// </summary>
		public double Delay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s end delay.
		/// </summary>
		public double EndDelay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s playbackRate.
		/// </summary>
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iteration start.
		/// </summary>
		public double IterationStart { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iterations.
		/// </summary>
		public double Iterations { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iteration duration.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s playback direction.
		/// </summary>
		public string Direction { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s fill mode.
		/// </summary>
		public string Fill { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s target node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s keyframes.
		/// </summary>
		public KeyframesRule KeyframesRule { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
