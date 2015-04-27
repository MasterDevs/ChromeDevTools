using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[Command(ProtocolName.Emulation.SetEmulatedMedia)]
	public class SetEmulatedMediaCommand
	{
		/// <summary>
		/// Gets or sets Media type to emulate. Empty string disables the override.
		/// </summary>
		public string Media { get; set; }
	}
}
