using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Disable)]
	public class DisableCommandResponse
	{
	}
}
