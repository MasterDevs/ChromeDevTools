using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Enables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Enable)]
	public class EnableCommandResponse
	{
	}
}
