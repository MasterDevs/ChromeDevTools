using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[Command(ProtocolName.LayerTree.Disable)]
	public class DisableCommand
	{
	}
}
