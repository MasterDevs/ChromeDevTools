using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// For testing.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetDataSizeLimitsForTest)]
	[SupportedBy("Chrome")]
	public class SetDataSizeLimitsForTestCommandResponse
	{
	}
}
