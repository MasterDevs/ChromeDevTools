using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnLoadCommandResponse
	{
	}
}
