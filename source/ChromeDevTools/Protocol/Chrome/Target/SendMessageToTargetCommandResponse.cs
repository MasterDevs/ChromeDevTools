using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Sends protocol message to the target with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.SendMessageToTarget)]
	[SupportedBy("Chrome")]
	public class SendMessageToTargetCommandResponse
	{
	}
}
