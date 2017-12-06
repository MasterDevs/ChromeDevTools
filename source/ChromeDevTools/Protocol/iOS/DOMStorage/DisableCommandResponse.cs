using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
