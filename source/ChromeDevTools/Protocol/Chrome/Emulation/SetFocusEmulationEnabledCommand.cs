using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables or disables simulating a focused and active page.
	/// </summary>
	[Command(ProtocolName.Emulation.SetFocusEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetFocusEmulationEnabledCommand: ICommand<SetFocusEmulationEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to enable to disable focus emulation.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
