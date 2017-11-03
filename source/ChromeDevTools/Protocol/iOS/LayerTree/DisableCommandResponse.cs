using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
