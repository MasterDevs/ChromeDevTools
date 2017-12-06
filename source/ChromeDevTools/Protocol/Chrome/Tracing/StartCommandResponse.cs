using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome")]
	public class StartCommandResponse
	{
	}
}
