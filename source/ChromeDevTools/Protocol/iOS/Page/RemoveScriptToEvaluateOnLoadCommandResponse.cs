using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[CommandResponse(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class RemoveScriptToEvaluateOnLoadCommandResponse
	{
	}
}
