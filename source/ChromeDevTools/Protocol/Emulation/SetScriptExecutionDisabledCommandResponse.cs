using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	public class SetScriptExecutionDisabledCommandResponse
	{
	}
}
