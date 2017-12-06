using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Gets the remote object of the Animation.
	/// </summary>
	[Command(ProtocolName.Animation.ResolveAnimation)]
	[SupportedBy("Chrome")]
	public class ResolveAnimationCommand: ICommand<ResolveAnimationCommandResponse>
	{
		/// <summary>
		/// Gets or sets Animation id.
		/// </summary>
		public string AnimationId { get; set; }
	}
}
