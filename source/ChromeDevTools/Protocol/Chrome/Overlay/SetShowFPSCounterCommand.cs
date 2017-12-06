using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowFPSCounter)]
	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommand: ICommand<SetShowFPSCounterCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing the FPS counter
		/// </summary>
		public bool Show { get; set; }
	}
}
