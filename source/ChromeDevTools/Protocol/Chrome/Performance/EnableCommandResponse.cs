using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Enable collecting and reporting metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Performance.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
