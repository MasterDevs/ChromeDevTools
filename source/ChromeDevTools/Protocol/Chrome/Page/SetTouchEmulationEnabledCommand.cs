using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[Command(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommand: ICommand<SetTouchEmulationEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets Touch/gesture events configuration. Default: current platform.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Configuration { get; set; }
	}
}
