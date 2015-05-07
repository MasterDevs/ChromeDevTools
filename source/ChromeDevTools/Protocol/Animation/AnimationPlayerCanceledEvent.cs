using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Event for AnimationPlayers in the frontend that have been cancelled.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationPlayerCanceled)]
	public class AnimationPlayerCanceledEvent
	{
		/// <summary>
		/// Gets or sets Id of the AnimationPlayer that was cancelled.
		/// </summary>
		public string PlayerId { get; set; }
	}
}
