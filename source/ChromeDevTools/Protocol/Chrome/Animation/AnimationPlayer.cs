using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// AnimationPlayer instance.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AnimationPlayer
	{
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s id.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s internal paused state.
		/// </summary>
		public bool PausedState { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s play state.
		/// </summary>
		public string PlayState { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s playback rate.
		/// </summary>
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s start time.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s current time.
		/// </summary>
		public double CurrentTime { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s source animation node.
		/// </summary>
		public AnimationNode Source { get; set; }
		/// <summary>
		/// Gets or sets Animation type of <code>AnimationPlayer</code>.
		/// </summary>
		public string Type { get; set; }
	}
}
