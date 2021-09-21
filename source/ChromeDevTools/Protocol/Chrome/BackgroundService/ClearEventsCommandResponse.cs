using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Clears all stored data for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.ClearEvents)]
	[SupportedBy("Chrome")]
	public class ClearEventsCommandResponse
	{
	}
}
