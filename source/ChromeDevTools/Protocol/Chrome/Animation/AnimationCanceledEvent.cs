using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Event for when an animation has been cancelled.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationCanceled)]
	[SupportedBy("Chrome")]
	public class AnimationCanceledEvent
	{
		/// <summary>
		/// Gets or sets Id of the animation that was cancelled.
		/// </summary>
		public string Id { get; set; }
	}
}
