using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Specifies whether to attach a page script stack id in requests
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetAttachDebugStack)]
	[SupportedBy("Chrome")]
	public class SetAttachDebugStackCommandResponse
	{
	}
}
