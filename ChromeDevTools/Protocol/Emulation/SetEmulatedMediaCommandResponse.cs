using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetEmulatedMedia)]
	public class SetEmulatedMediaCommandResponse
	{
	}
}
