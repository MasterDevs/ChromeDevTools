using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetEmitTouchEventsForMouse)]
	[SupportedBy("Chrome")]
	public class SetEmitTouchEventsForMouseCommand: ICommand<SetEmitTouchEventsForMouseCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether touch emulation based on mouse input should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets Touch/gesture events configuration. Default: current platform.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Configuration { get; set; }
	}
}
