using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
