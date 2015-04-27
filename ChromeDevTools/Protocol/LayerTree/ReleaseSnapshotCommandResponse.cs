using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReleaseSnapshot)]
	public class ReleaseSnapshotCommandResponse
	{
	}
}
