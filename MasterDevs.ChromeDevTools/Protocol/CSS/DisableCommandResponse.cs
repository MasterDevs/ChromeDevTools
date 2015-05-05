using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.Disable)]
	public class DisableCommandResponse
	{
	}
}
