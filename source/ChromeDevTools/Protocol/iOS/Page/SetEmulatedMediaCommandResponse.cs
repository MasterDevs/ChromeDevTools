using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetEmulatedMedia)]
	[SupportedBy("iOS")]
	public class SetEmulatedMediaCommandResponse
	{
	}
}
