using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>
	[Command(ProtocolName.Animation.SetTiming)]
	[SupportedBy("Chrome")]
	public class SetTimingCommand: ICommand<SetTimingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Animation id.
		/// </summary>
		public string AnimationId { get; set; }
		/// <summary>
		/// Gets or sets Duration of the animation.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets Delay of the animation.
		/// </summary>
		public double Delay { get; set; }
	}
}
