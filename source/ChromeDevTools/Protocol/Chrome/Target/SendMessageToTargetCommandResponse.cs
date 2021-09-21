using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Sends protocol message over session with given id.
	/// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
	/// and crbug.com/991325.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Target.SendMessageToTarget)]
	[SupportedBy("Chrome")]
	public class SendMessageToTargetCommandResponse
	{
	}
}
