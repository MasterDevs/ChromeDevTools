using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Always returns true.
	/// </summary>
	[Command(ProtocolName.Debugger.CanSetScriptSource)]
	[SupportedBy("Chrome")]
	public class CanSetScriptSourceCommand
	{
	}
}
