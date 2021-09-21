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
		/// Gets or sets `Animation`'s id.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s internal paused state.
		/// </summary>
		public bool PausedState { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s play state.
		/// </summary>
		public string PlayState { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s playback rate.
		/// </summary>
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s start time.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s current time.
		/// </summary>
		public double CurrentTime { get; set; }
		/// <summary>
		/// Gets or sets Animation type of `Animation`.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets `Animation`'s source animation node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AnimationEffect Source { get; set; }
		/// <summary>
		/// Gets or sets A unique ID for `Animation` representing the sources that triggered this CSS
		/// animation/transition.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CssId { get; set; }
	}
}
