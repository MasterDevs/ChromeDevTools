using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>
	[Command(ProtocolName.Debugger.Disable)]
	public class DisableCommand
	{
	}
}
