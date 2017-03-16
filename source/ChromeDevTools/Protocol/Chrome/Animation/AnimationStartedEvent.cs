using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Event for animation that has been started.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationStarted)]
	[SupportedBy("Chrome")]
	public class AnimationStartedEvent
	{
		/// <summary>
		/// Gets or sets Animation that was started.
		/// </summary>
		public Animation Animation { get; set; }
	}
}
