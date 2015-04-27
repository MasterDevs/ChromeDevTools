using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	public class SetScriptExecutionDisabledCommandResponse
	{
	}
}
