using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[Command(ProtocolName.Emulation.CanEmulate)]
	public class CanEmulateCommand
	{
	}
}
