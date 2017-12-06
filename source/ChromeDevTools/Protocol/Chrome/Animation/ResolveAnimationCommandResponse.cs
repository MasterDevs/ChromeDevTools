using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Gets the remote object of the Animation.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.ResolveAnimation)]
	[SupportedBy("Chrome")]
	public class ResolveAnimationCommandResponse
	{
		/// <summary>
		/// Gets or sets Corresponding remote object.
		/// </summary>
		public Runtime.RemoteObject RemoteObject { get; set; }
	}
}
