using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
	/// </summary>
	[Command(ProtocolName.Debugger.Enable)]
	public class EnableCommand
	{
	}
}
