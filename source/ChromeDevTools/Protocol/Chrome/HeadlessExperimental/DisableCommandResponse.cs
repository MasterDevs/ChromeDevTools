using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Disables headless events for the target.
	/// </summary>
	[CommandResponse(ProtocolName.HeadlessExperimental.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
