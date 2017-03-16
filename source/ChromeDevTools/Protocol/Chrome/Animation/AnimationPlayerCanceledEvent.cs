using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Event for AnimationPlayers in the frontend that have been cancelled.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationPlayerCanceled)]
	[SupportedBy("Chrome")]
	public class AnimationPlayerCanceledEvent
	{
		/// <summary>
		/// Gets or sets Id of the AnimationPlayer that was cancelled.
		/// </summary>
		public string PlayerId { get; set; }
	}
}
