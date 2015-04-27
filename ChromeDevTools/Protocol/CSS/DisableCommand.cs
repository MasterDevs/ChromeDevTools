using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>
	[Command(ProtocolName.CSS.Disable)]
	public class DisableCommand
	{
	}
}
