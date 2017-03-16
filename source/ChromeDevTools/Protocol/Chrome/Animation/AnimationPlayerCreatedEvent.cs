using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Event for each animation player that has been created.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationPlayerCreated)]
	[SupportedBy("Chrome")]
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
