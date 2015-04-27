using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Enables compositing tree inspection.
	/// </summary>
	[Command(ProtocolName.LayerTree.Enable)]
	public class EnableCommand
	{
	}
}
