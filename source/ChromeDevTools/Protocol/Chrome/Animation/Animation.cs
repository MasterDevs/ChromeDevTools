using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Animation instance.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Animation
	{
		/// <summary>
		/// Gets or sets <code>Animation</code>'s id.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s internal paused state.
		/// </summary>
		public bool PausedState { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s play state.
		/// </summary>
		public string PlayState { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s playback rate.
		/// </summary>
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s start time.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s current time.
		/// </summary>
		public double CurrentTime { get; set; }
		/// <summary>
		/// Gets or sets <code>Animation</code>'s source animation node.
		/// </summary>
		public AnimationEffect Source { get; set; }
		/// <summary>
		/// Gets or sets Animation type of <code>Animation</code>.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets A unique ID for <code>Animation</code> representing the sources that triggered this CSS animation/transition.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CssId { get; set; }
	}
}
