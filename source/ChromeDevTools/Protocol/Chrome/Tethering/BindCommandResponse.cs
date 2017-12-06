using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>
	[CommandResponse(ProtocolName.Tethering.Bind)]
	[SupportedBy("Chrome")]
	public class BindCommandResponse
	{
	}
}
