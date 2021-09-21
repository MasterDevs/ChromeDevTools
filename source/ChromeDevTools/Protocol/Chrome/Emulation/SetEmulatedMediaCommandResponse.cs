using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given media type or media feature for CSS media queries.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetEmulatedMedia)]
	[SupportedBy("Chrome")]
	public class SetEmulatedMediaCommandResponse
	{
	}
}
