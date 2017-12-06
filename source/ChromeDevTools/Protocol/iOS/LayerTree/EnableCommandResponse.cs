using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Enables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
