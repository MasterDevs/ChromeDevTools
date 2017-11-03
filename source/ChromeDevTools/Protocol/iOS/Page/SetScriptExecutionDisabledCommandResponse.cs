using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetScriptExecutionDisabled)]
	[SupportedBy("iOS")]
	public class SetScriptExecutionDisabledCommandResponse
	{
	}
}
