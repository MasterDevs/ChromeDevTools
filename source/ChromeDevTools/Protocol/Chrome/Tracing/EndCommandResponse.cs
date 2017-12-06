using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.End)]
	[SupportedBy("Chrome")]
	public class EndCommandResponse
	{
	}
}
