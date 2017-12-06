using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the paused state of a set of animations.
	/// </summary>
	[Command(ProtocolName.Animation.SetPaused)]
	[SupportedBy("Chrome")]
	public class SetPausedCommand: ICommand<SetPausedCommandResponse>
	{
		/// <summary>
		/// Gets or sets Animations to set the pause state of.
		/// </summary>
		public string[] Animations { get; set; }
		/// <summary>
		/// Gets or sets Paused state to set to.
		/// </summary>
		public bool Paused { get; set; }
	}
}
