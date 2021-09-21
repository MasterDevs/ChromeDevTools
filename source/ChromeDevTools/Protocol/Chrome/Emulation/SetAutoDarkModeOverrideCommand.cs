using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Automatically render all web contents using a dark theme.
	/// </summary>
	[Command(ProtocolName.Emulation.SetAutoDarkModeOverride)]
	[SupportedBy("Chrome")]
	public class SetAutoDarkModeOverrideCommand: ICommand<SetAutoDarkModeOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to enable or disable automatic dark mode.
		/// If not specified, any existing override will be cleared.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Enabled { get; set; }
	}
}
