using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[Command(ProtocolName.Emulation.CanEmulate)]
	public class CanEmulateCommand
	{
	}
}
