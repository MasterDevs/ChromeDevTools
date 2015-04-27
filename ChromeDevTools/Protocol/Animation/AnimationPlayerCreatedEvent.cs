using ChromeDevTools;

namespace ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Event for each animation player that has been created.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationPlayerCreated)]
	public class AnimationPlayerCreatedEvent
	{
		/// <summary>
		/// Gets or sets AnimationPlayer that was created.
		/// </summary>
		public AnimationPlayer Player { get; set; }
		/// <summary>
		/// Gets or sets Whether the timeline should be reset.
		/// </summary>
		public bool ResetTimeline { get; set; }
	}
}
