using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Disable)]
	public class DisableCommandResponse
	{
	}
}
