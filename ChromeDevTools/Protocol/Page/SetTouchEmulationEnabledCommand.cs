using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[Command(ProtocolName.Page.SetTouchEmulationEnabled)]
	public class SetTouchEmulationEnabledCommand
	{
		/// <summary>
		/// Gets or sets Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets Touch/gesture events configuration. Default: current platform.
		/// </summary>
		public string Configuration { get; set; }
	}
}
